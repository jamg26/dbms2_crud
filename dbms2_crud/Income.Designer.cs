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
            this.txtNetGross = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.checkSSS = new System.Windows.Forms.CheckBox();
            this.checkPagibig = new System.Windows.Forms.CheckBox();
            this.txtPagibigLoans = new System.Windows.Forms.TextBox();
            this.txtSSSLoans = new System.Windows.Forms.TextBox();
            this.txtOtherLoansName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOtherLoans = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPremPagibig = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txtPremPhil = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.txtPremSSS = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(13, 13);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(846, 21);
            this.cmbEmployees.TabIndex = 0;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSalary.Location = new System.Drawing.Point(6, 34);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(161, 20);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.Text = "0.00";
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            // 
            // numWorkDays
            // 
            this.numWorkDays.Location = new System.Drawing.Point(6, 77);
            this.numWorkDays.Name = "numWorkDays";
            this.numWorkDays.Size = new System.Drawing.Size(161, 20);
            this.numWorkDays.TabIndex = 2;
            this.numWorkDays.ValueChanged += new System.EventHandler(this.numWorkDays_ValueChanged);
            // 
            // numOT
            // 
            this.numOT.Location = new System.Drawing.Point(5, 119);
            this.numOT.Name = "numOT";
            this.numOT.Size = new System.Drawing.Size(162, 20);
            this.numOT.TabIndex = 3;
            this.numOT.ValueChanged += new System.EventHandler(this.numOT_ValueChanged);
            // 
            // numAbsent
            // 
            this.numAbsent.Location = new System.Drawing.Point(6, 35);
            this.numAbsent.Name = "numAbsent";
            this.numAbsent.Size = new System.Drawing.Size(161, 20);
            this.numAbsent.TabIndex = 4;
            this.numAbsent.ValueChanged += new System.EventHandler(this.numAbsent_ValueChanged);
            // 
            // txtLoans
            // 
            this.txtLoans.Enabled = false;
            this.txtLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLoans.Location = new System.Drawing.Point(15, 265);
            this.txtLoans.Name = "txtLoans";
            this.txtLoans.Size = new System.Drawing.Size(131, 20);
            this.txtLoans.TabIndex = 5;
            this.txtLoans.Text = "0.00";
            this.txtLoans.TextChanged += new System.EventHandler(this.txtLoans_TextChanged);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNetPay.Location = new System.Drawing.Point(15, 351);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(161, 20);
            this.txtNetPay.TabIndex = 6;
            this.txtNetPay.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Working Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Overtime Hours (40/hr)";
            // 
            // txtNetGross
            // 
            this.txtNetGross.Enabled = false;
            this.txtNetGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetGross.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNetGross.Location = new System.Drawing.Point(6, 350);
            this.txtNetGross.Name = "txtNetGross";
            this.txtNetGross.Size = new System.Drawing.Size(161, 20);
            this.txtNetGross.TabIndex = 1;
            this.txtNetGross.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Net Gross";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Absences";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Loans";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Net Pay";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(789, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNetGross);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numWorkDays);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numOT);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 382);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INCOME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numAbsent);
            this.groupBox2.Controls.Add(this.txtLoans);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNetPay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(367, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 382);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DEDUCTION";
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Location = new System.Drawing.Point(157, 20);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(52, 17);
            this.checkOther.TabIndex = 10;
            this.checkOther.Text = "Other";
            this.checkOther.UseVisualStyleBackColor = true;
            this.checkOther.CheckedChanged += new System.EventHandler(this.checkOther_CheckedChanged);
            // 
            // checkSSS
            // 
            this.checkSSS.AutoSize = true;
            this.checkSSS.Location = new System.Drawing.Point(78, 20);
            this.checkSSS.Name = "checkSSS";
            this.checkSSS.Size = new System.Drawing.Size(47, 17);
            this.checkSSS.TabIndex = 9;
            this.checkSSS.Text = "SSS";
            this.checkSSS.UseVisualStyleBackColor = true;
            this.checkSSS.CheckedChanged += new System.EventHandler(this.checkSSS_CheckedChanged);
            // 
            // checkPagibig
            // 
            this.checkPagibig.AutoSize = true;
            this.checkPagibig.Location = new System.Drawing.Point(6, 19);
            this.checkPagibig.Name = "checkPagibig";
            this.checkPagibig.Size = new System.Drawing.Size(65, 17);
            this.checkPagibig.TabIndex = 8;
            this.checkPagibig.Text = "Pag-Ibig";
            this.checkPagibig.UseVisualStyleBackColor = true;
            this.checkPagibig.CheckedChanged += new System.EventHandler(this.checkPagibig_CheckedChanged);
            // 
            // txtPagibigLoans
            // 
            this.txtPagibigLoans.Enabled = false;
            this.txtPagibigLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagibigLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPagibigLoans.Location = new System.Drawing.Point(6, 43);
            this.txtPagibigLoans.Name = "txtPagibigLoans";
            this.txtPagibigLoans.Size = new System.Drawing.Size(65, 20);
            this.txtPagibigLoans.TabIndex = 11;
            this.txtPagibigLoans.Text = "0.00";
            this.txtPagibigLoans.TextChanged += new System.EventHandler(this.txtPagibigLoans_TextChanged);
            this.txtPagibigLoans.Enter += new System.EventHandler(this.txtPagibigLoans_Enter);
            // 
            // txtSSSLoans
            // 
            this.txtSSSLoans.Enabled = false;
            this.txtSSSLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSSSLoans.Location = new System.Drawing.Point(78, 42);
            this.txtSSSLoans.Name = "txtSSSLoans";
            this.txtSSSLoans.Size = new System.Drawing.Size(72, 20);
            this.txtSSSLoans.TabIndex = 12;
            this.txtSSSLoans.Text = "0.00";
            this.txtSSSLoans.TextChanged += new System.EventHandler(this.txtSSSLoans_TextChanged);
            this.txtSSSLoans.Enter += new System.EventHandler(this.txtSSSLoans_Enter);
            // 
            // txtOtherLoansName
            // 
            this.txtOtherLoansName.Enabled = false;
            this.txtOtherLoansName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherLoansName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOtherLoansName.Location = new System.Drawing.Point(157, 42);
            this.txtOtherLoansName.Name = "txtOtherLoansName";
            this.txtOtherLoansName.Size = new System.Drawing.Size(52, 20);
            this.txtOtherLoansName.TabIndex = 13;
            this.txtOtherLoansName.Text = "Name";
            this.txtOtherLoansName.Enter += new System.EventHandler(this.txtOtherLoansName_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOtherLoans);
            this.groupBox3.Controls.Add(this.checkPagibig);
            this.groupBox3.Controls.Add(this.txtOtherLoansName);
            this.groupBox3.Controls.Add(this.checkSSS);
            this.groupBox3.Controls.Add(this.txtSSSLoans);
            this.groupBox3.Controls.Add(this.checkOther);
            this.groupBox3.Controls.Add(this.txtPagibigLoans);
            this.groupBox3.Location = new System.Drawing.Point(9, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 78);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOANS";
            // 
            // txtOtherLoans
            // 
            this.txtOtherLoans.Enabled = false;
            this.txtOtherLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOtherLoans.Location = new System.Drawing.Point(215, 42);
            this.txtOtherLoans.Name = "txtOtherLoans";
            this.txtOtherLoans.Size = new System.Drawing.Size(100, 20);
            this.txtOtherLoans.TabIndex = 14;
            this.txtOtherLoans.Text = "0.00";
            this.txtOtherLoans.TextChanged += new System.EventHandler(this.txtOtherLoans_TextChanged);
            this.txtOtherLoans.Enter += new System.EventHandler(this.txtOtherLoans_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPremSSS);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.txtPremPagibig);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.txtPremPhil);
            this.groupBox4.Location = new System.Drawing.Point(9, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 99);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PREMIUM LOANS";
            // 
            // txtPremPagibig
            // 
            this.txtPremPagibig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremPagibig.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremPagibig.Location = new System.Drawing.Point(6, 44);
            this.txtPremPagibig.Name = "txtPremPagibig";
            this.txtPremPagibig.Size = new System.Drawing.Size(65, 20);
            this.txtPremPagibig.TabIndex = 11;
            this.txtPremPagibig.Text = "0.00";
            this.txtPremPagibig.TextChanged += new System.EventHandler(this.txtPremPagibig_TextChanged);
            this.txtPremPagibig.Enter += new System.EventHandler(this.txtPremPagibig_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(157, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(47, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "SSS";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txtPremPhil
            // 
            this.txtPremPhil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremPhil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremPhil.Location = new System.Drawing.Point(78, 43);
            this.txtPremPhil.Name = "txtPremPhil";
            this.txtPremPhil.Size = new System.Drawing.Size(72, 20);
            this.txtPremPhil.TabIndex = 12;
            this.txtPremPhil.Text = "0.00";
            this.txtPremPhil.TextChanged += new System.EventHandler(this.txtPremPhil_TextChanged);
            this.txtPremPhil.Enter += new System.EventHandler(this.txtPremPhil_Enter);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(78, 21);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Philhealth";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // txtPremSSS
            // 
            this.txtPremSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremSSS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremSSS.Location = new System.Drawing.Point(157, 43);
            this.txtPremSSS.Name = "txtPremSSS";
            this.txtPremSSS.Size = new System.Drawing.Size(52, 20);
            this.txtPremSSS.TabIndex = 13;
            this.txtPremSSS.Text = "0.00";
            this.txtPremSSS.TextChanged += new System.EventHandler(this.txtPremSSS_TextChanged);
            this.txtPremSSS.Enter += new System.EventHandler(this.txtPremSSS_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(6, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(65, 17);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Pag-Ibig";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbEmployees);
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Income_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numWorkDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtNetGross;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkPagibig;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.CheckBox checkSSS;
        private System.Windows.Forms.TextBox txtOtherLoansName;
        private System.Windows.Forms.TextBox txtSSSLoans;
        private System.Windows.Forms.TextBox txtPagibigLoans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOtherLoans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPremSSS;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox txtPremPagibig;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox txtPremPhil;


    }
}