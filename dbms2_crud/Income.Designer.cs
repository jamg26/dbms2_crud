namespace dbms2_crud {
    partial class Income {
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
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.numWorkDays = new System.Windows.Forms.NumericUpDown();
            this.numOT = new System.Windows.Forms.NumericUpDown();
            this.numAbsent = new System.Windows.Forms.NumericUpDown();
            this.txtLoans = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNetGross = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsent)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(13, 13);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(370, 21);
            this.cmbEmployees.TabIndex = 0;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(13, 56);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(161, 20);
            this.txtSalary.TabIndex = 1;
            // 
            // numWorkDays
            // 
            this.numWorkDays.Location = new System.Drawing.Point(13, 98);
            this.numWorkDays.Name = "numWorkDays";
            this.numWorkDays.Size = new System.Drawing.Size(161, 20);
            this.numWorkDays.TabIndex = 2;
            this.numWorkDays.ValueChanged += new System.EventHandler(this.numWorkDays_ValueChanged);
            // 
            // numOT
            // 
            this.numOT.Location = new System.Drawing.Point(12, 140);
            this.numOT.Name = "numOT";
            this.numOT.Size = new System.Drawing.Size(162, 20);
            this.numOT.TabIndex = 3;
            this.numOT.ValueChanged += new System.EventHandler(this.numOT_ValueChanged);
            // 
            // numAbsent
            // 
            this.numAbsent.Location = new System.Drawing.Point(13, 182);
            this.numAbsent.Name = "numAbsent";
            this.numAbsent.Size = new System.Drawing.Size(161, 20);
            this.numAbsent.TabIndex = 4;
            this.numAbsent.ValueChanged += new System.EventHandler(this.numAbsent_ValueChanged);
            // 
            // txtLoans
            // 
            this.txtLoans.Location = new System.Drawing.Point(13, 224);
            this.txtLoans.Name = "txtLoans";
            this.txtLoans.Size = new System.Drawing.Size(161, 20);
            this.txtLoans.TabIndex = 5;
            this.txtLoans.TextChanged += new System.EventHandler(this.txtLoans_TextChanged);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Location = new System.Drawing.Point(13, 266);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(161, 20);
            this.txtNetPay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Working Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Overtime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "days";
            // 
            // txtNetGross
            // 
            this.txtNetGross.Enabled = false;
            this.txtNetGross.Location = new System.Drawing.Point(235, 56);
            this.txtNetGross.Name = "txtNetGross";
            this.txtNetGross.Size = new System.Drawing.Size(161, 20);
            this.txtNetGross.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Net Gross";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Absences";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loans";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Net Pay";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(345, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 331);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtLoans);
            this.Controls.Add(this.numAbsent);
            this.Controls.Add(this.numOT);
            this.Controls.Add(this.numWorkDays);
            this.Controls.Add(this.txtNetGross);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbEmployees);
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Income_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numWorkDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.NumericUpDown numWorkDays;
        private System.Windows.Forms.NumericUpDown numOT;
        private System.Windows.Forms.NumericUpDown numAbsent;
        private System.Windows.Forms.TextBox txtLoans;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNetGross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;


    }
}