namespace NewLazy {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTblName = new System.Windows.Forms.TextBox();
            this.txtKeyField = new System.Windows.Forms.TextBox();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.txtOtherField = new System.Windows.Forms.TextBox();
            this.txtOtherValue = new System.Windows.Forms.TextBox();
            this.txtInsertQuery = new System.Windows.Forms.TextBox();
            this.txtUpdateQuery = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key field";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Other field";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Other value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Key value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Controls.Add(this.txtUpdateQuery);
            this.groupBox1.Controls.Add(this.txtInsertQuery);
            this.groupBox1.Controls.Add(this.txtOtherValue);
            this.groupBox1.Controls.Add(this.txtOtherField);
            this.groupBox1.Controls.Add(this.txtKeyValue);
            this.groupBox1.Controls.Add(this.txtKeyField);
            this.groupBox1.Controls.Add(this.txtTblName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C# - SQL Query Maker";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Insert Query";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Update query";
            // 
            // txtTblName
            // 
            this.txtTblName.Location = new System.Drawing.Point(149, 51);
            this.txtTblName.Name = "txtTblName";
            this.txtTblName.Size = new System.Drawing.Size(247, 26);
            this.txtTblName.TabIndex = 0;
            // 
            // txtKeyField
            // 
            this.txtKeyField.Location = new System.Drawing.Point(149, 92);
            this.txtKeyField.Name = "txtKeyField";
            this.txtKeyField.Size = new System.Drawing.Size(247, 26);
            this.txtKeyField.TabIndex = 1;
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(149, 133);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(247, 26);
            this.txtKeyValue.TabIndex = 2;
            // 
            // txtOtherField
            // 
            this.txtOtherField.Location = new System.Drawing.Point(149, 174);
            this.txtOtherField.Name = "txtOtherField";
            this.txtOtherField.Size = new System.Drawing.Size(247, 26);
            this.txtOtherField.TabIndex = 3;
            // 
            // txtOtherValue
            // 
            this.txtOtherValue.Location = new System.Drawing.Point(149, 215);
            this.txtOtherValue.Name = "txtOtherValue";
            this.txtOtherValue.Size = new System.Drawing.Size(247, 26);
            this.txtOtherValue.TabIndex = 4;
            // 
            // txtInsertQuery
            // 
            this.txtInsertQuery.Location = new System.Drawing.Point(149, 256);
            this.txtInsertQuery.Name = "txtInsertQuery";
            this.txtInsertQuery.Size = new System.Drawing.Size(247, 26);
            this.txtInsertQuery.TabIndex = 5;
            // 
            // txtUpdateQuery
            // 
            this.txtUpdateQuery.Location = new System.Drawing.Point(149, 297);
            this.txtUpdateQuery.Name = "txtUpdateQuery";
            this.txtUpdateQuery.Size = new System.Drawing.Size(247, 26);
            this.txtUpdateQuery.TabIndex = 6;
            // 
            // btnMake
            // 
            this.btnMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMake.Location = new System.Drawing.Point(412, 51);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(85, 67);
            this.btnMake.TabIndex = 7;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(578, 485);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Lazy Program - minhphong306";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txtUpdateQuery;
        private System.Windows.Forms.TextBox txtInsertQuery;
        private System.Windows.Forms.TextBox txtOtherValue;
        private System.Windows.Forms.TextBox txtOtherField;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.TextBox txtKeyField;
        private System.Windows.Forms.TextBox txtTblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

