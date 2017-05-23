using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLazy {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            string tableName = txtTblName.Text;
            string keyField = txtKeyField.Text;
            string keyValue = txtKeyValue.Text;

            string insertBodyStr = "(";
            string insertBodyStr2 = ") VALUES( ";
            string updateBodyStr = "";

            string insertTailStr = ", ";
           

            string[] fieldArr = txtOtherField.Text.Split(',');
            string[] valueArr = txtOtherValue.Text.Split(',');
            

            if (fieldArr.Length != valueArr.Length)
            {
                MessageBox.Show("Length of field and value is not equal.");
            }

            int length = fieldArr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                insertBodyStr += fieldArr[i] + ", ";
                insertBodyStr2 += "'{" + i + "}', ";

                updateBodyStr += fieldArr[i] + " = '{" + i + "}', ";

                insertTailStr += valueArr[i] + ", ";
            }

            insertBodyStr += fieldArr[length - 1];
            insertBodyStr2 +=  "'{" + (length - 1) + "}')\" ";

            updateBodyStr += fieldArr[length - 1] + " = '{" + (length - 1) + "}' ";

            insertTailStr += valueArr[length - 1];

            string updateTailStr1 = " WHERE " + keyField + " = '{" + length + "}')\"";
            string updateTailStr2 = ", " + keyValue + ") ";

            string insertHeadStr = "string.Format(\"INSERT INTO " + tableName + " ";
            string updateHeadStr = "string.Format(\"UPDATE " + tableName + " SET ";


            string insertResult = insertHeadStr + insertBodyStr + insertBodyStr2 + insertTailStr + ")";
            string updateResult = updateHeadStr + updateBodyStr + updateTailStr1+ insertTailStr + updateTailStr2;

            txtInsertQuery.Text = insertResult;
            txtUpdateQuery.Text = updateResult;
        }
    }
}
