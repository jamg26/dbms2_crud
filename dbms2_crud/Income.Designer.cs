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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPremSSS = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.txtPremPagibig = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.txtPremPhil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOtherLoans = new System.Windows.Forms.TextBox();
            this.checkPagibig = new System.Windows.Forms.CheckBox();
            this.txtOtherLoansName = new System.Windows.Forms.TextBox();
            this.checkSSS = new System.Windows.Forms.CheckBox();
            this.txtSSSLoans = new System.Windows.Forms.TextBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.txtPagibigLoans = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.lblPremLoans = new System.Windows.Forms.Label();
            this.labelLoans = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblOTPay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBasicPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblNetGross = new System.Windows.Forms.Label();
            this.lblAbs = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(13, 13);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(846, 22);
            this.cmbEmployees.TabIndex = 0;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSalary.Location = new System.Drawing.Point(6, 34);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(161, 21);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.Text = "0.00";
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            // 
            // numWorkDays
            // 
            this.numWorkDays.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWorkDays.Location = new System.Drawing.Point(6, 77);
            this.numWorkDays.Name = "numWorkDays";
            this.numWorkDays.Size = new System.Drawing.Size(161, 21);
            this.numWorkDays.TabIndex = 2;
            this.numWorkDays.ValueChanged += new System.EventHandler(this.numWorkDays_ValueChanged);
            // 
            // numOT
            // 
            this.numOT.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOT.Location = new System.Drawing.Point(5, 119);
            this.numOT.Name = "numOT";
            this.numOT.Size = new System.Drawing.Size(162, 21);
            this.numOT.TabIndex = 3;
            this.numOT.ValueChanged += new System.EventHandler(this.numOT_ValueChanged);
            // 
            // numAbsent
            // 
            this.numAbsent.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAbsent.Location = new System.Drawing.Point(6, 35);
            this.numAbsent.Name = "numAbsent";
            this.numAbsent.Size = new System.Drawing.Size(161, 21);
            this.numAbsent.TabIndex = 4;
            this.numAbsent.ValueChanged += new System.EventHandler(this.numAbsent_ValueChanged);
            // 
            // txtLoans
            // 
            this.txtLoans.Enabled = false;
            this.txtLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLoans.Location = new System.Drawing.Point(15, 265);
            this.txtLoans.Name = "txtLoans";
            this.txtLoans.Size = new System.Drawing.Size(131, 21);
            this.txtLoans.TabIndex = 5;
            this.txtLoans.Text = "0.00";
            this.txtLoans.TextChanged += new System.EventHandler(this.txtLoans_TextChanged);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNetPay.Location = new System.Drawing.Point(15, 351);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(161, 21);
            this.txtNetPay.TabIndex = 6;
            this.txtNetPay.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Working Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Overtime Hours (40/hr)";
            // 
            // txtNetGross
            // 
            this.txtNetGross.Enabled = false;
            this.txtNetGross.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetGross.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNetGross.Location = new System.Drawing.Point(6, 350);
            this.txtNetGross.Name = "txtNetGross";
            this.txtNetGross.Size = new System.Drawing.Size(161, 21);
            this.txtNetGross.TabIndex = 1;
            this.txtNetGross.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Net Gross";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Absences";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Loans";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Net Pay";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 382);
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
            this.groupBox2.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(215, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 382);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DEDUCTION";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPremSSS);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.txtPremPagibig);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.txtPremPhil);
            this.groupBox4.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 99);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PREMIUM LOANS";
            // 
            // txtPremSSS
            // 
            this.txtPremSSS.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremSSS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremSSS.Location = new System.Drawing.Point(90, 44);
            this.txtPremSSS.Name = "txtPremSSS";
            this.txtPremSSS.Size = new System.Drawing.Size(52, 21);
            this.txtPremSSS.TabIndex = 13;
            this.txtPremSSS.Text = "0.00";
            this.txtPremSSS.TextChanged += new System.EventHandler(this.txtPremSSS_TextChanged);
            this.txtPremSSS.Leave += new System.EventHandler(this.txtPremSSS_Leave);
            this.txtPremSSS.Enter += new System.EventHandler(this.txtPremSSS_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Enabled = false;
            this.checkBox6.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(6, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(82, 18);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Pag-Ibig";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // txtPremPagibig
            // 
            this.txtPremPagibig.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremPagibig.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremPagibig.Location = new System.Drawing.Point(6, 44);
            this.txtPremPagibig.Name = "txtPremPagibig";
            this.txtPremPagibig.Size = new System.Drawing.Size(65, 21);
            this.txtPremPagibig.TabIndex = 11;
            this.txtPremPagibig.Text = "0.00";
            this.txtPremPagibig.TextChanged += new System.EventHandler(this.txtPremPagibig_TextChanged);
            this.txtPremPagibig.Leave += new System.EventHandler(this.txtPremPagibig_Leave);
            this.txtPremPagibig.Enter += new System.EventHandler(this.txtPremPagibig_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(90, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(47, 18);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "SSS";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(157, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(96, 18);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Philhealth";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // txtPremPhil
            // 
            this.txtPremPhil.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremPhil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPremPhil.Location = new System.Drawing.Point(157, 44);
            this.txtPremPhil.Name = "txtPremPhil";
            this.txtPremPhil.Size = new System.Drawing.Size(72, 21);
            this.txtPremPhil.TabIndex = 12;
            this.txtPremPhil.Text = "0.00";
            this.txtPremPhil.TextChanged += new System.EventHandler(this.txtPremPhil_TextChanged);
            this.txtPremPhil.Leave += new System.EventHandler(this.txtPremPhil_Leave);
            this.txtPremPhil.Enter += new System.EventHandler(this.txtPremPhil_Enter);
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
            this.groupBox3.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 78);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOANS";
            // 
            // txtOtherLoans
            // 
            this.txtOtherLoans.Enabled = false;
            this.txtOtherLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOtherLoans.Location = new System.Drawing.Point(227, 42);
            this.txtOtherLoans.Name = "txtOtherLoans";
            this.txtOtherLoans.Size = new System.Drawing.Size(100, 21);
            this.txtOtherLoans.TabIndex = 14;
            this.txtOtherLoans.Text = "0.00";
            this.txtOtherLoans.TextChanged += new System.EventHandler(this.txtOtherLoans_TextChanged);
            this.txtOtherLoans.Leave += new System.EventHandler(this.txtOtherLoans_Leave);
            this.txtOtherLoans.Enter += new System.EventHandler(this.txtOtherLoans_Enter);
            // 
            // checkPagibig
            // 
            this.checkPagibig.AutoSize = true;
            this.checkPagibig.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPagibig.Location = new System.Drawing.Point(6, 19);
            this.checkPagibig.Name = "checkPagibig";
            this.checkPagibig.Size = new System.Drawing.Size(82, 18);
            this.checkPagibig.TabIndex = 8;
            this.checkPagibig.Text = "Pag-Ibig";
            this.checkPagibig.UseVisualStyleBackColor = true;
            this.checkPagibig.CheckedChanged += new System.EventHandler(this.checkPagibig_CheckedChanged);
            // 
            // txtOtherLoansName
            // 
            this.txtOtherLoansName.Enabled = false;
            this.txtOtherLoansName.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherLoansName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOtherLoansName.Location = new System.Drawing.Point(169, 42);
            this.txtOtherLoansName.Name = "txtOtherLoansName";
            this.txtOtherLoansName.Size = new System.Drawing.Size(52, 21);
            this.txtOtherLoansName.TabIndex = 13;
            this.txtOtherLoansName.Text = "Name";
            this.txtOtherLoansName.Enter += new System.EventHandler(this.txtOtherLoansName_Enter);
            // 
            // checkSSS
            // 
            this.checkSSS.AutoSize = true;
            this.checkSSS.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSSS.Location = new System.Drawing.Point(90, 20);
            this.checkSSS.Name = "checkSSS";
            this.checkSSS.Size = new System.Drawing.Size(47, 18);
            this.checkSSS.TabIndex = 9;
            this.checkSSS.Text = "SSS";
            this.checkSSS.UseVisualStyleBackColor = true;
            this.checkSSS.CheckedChanged += new System.EventHandler(this.checkSSS_CheckedChanged);
            // 
            // txtSSSLoans
            // 
            this.txtSSSLoans.Enabled = false;
            this.txtSSSLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSSSLoans.Location = new System.Drawing.Point(90, 42);
            this.txtSSSLoans.Name = "txtSSSLoans";
            this.txtSSSLoans.Size = new System.Drawing.Size(72, 21);
            this.txtSSSLoans.TabIndex = 12;
            this.txtSSSLoans.Text = "0.00";
            this.txtSSSLoans.TextChanged += new System.EventHandler(this.txtSSSLoans_TextChanged);
            this.txtSSSLoans.Leave += new System.EventHandler(this.txtSSSLoans_Leave);
            this.txtSSSLoans.Enter += new System.EventHandler(this.txtSSSLoans_Enter);
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOther.Location = new System.Drawing.Point(169, 20);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(61, 18);
            this.checkOther.TabIndex = 10;
            this.checkOther.Text = "Other";
            this.checkOther.UseVisualStyleBackColor = true;
            this.checkOther.CheckedChanged += new System.EventHandler(this.checkOther_CheckedChanged);
            // 
            // txtPagibigLoans
            // 
            this.txtPagibigLoans.Enabled = false;
            this.txtPagibigLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagibigLoans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPagibigLoans.Location = new System.Drawing.Point(6, 43);
            this.txtPagibigLoans.Name = "txtPagibigLoans";
            this.txtPagibigLoans.Size = new System.Drawing.Size(65, 21);
            this.txtPagibigLoans.TabIndex = 11;
            this.txtPagibigLoans.Text = "0.00";
            this.txtPagibigLoans.TextChanged += new System.EventHandler(this.txtPagibigLoans_TextChanged);
            this.txtPagibigLoans.Leave += new System.EventHandler(this.txtPagibigLoans_Leave);
            this.txtPagibigLoans.Enter += new System.EventHandler(this.txtPagibigLoans_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblJob);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.lblDept);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lblTotalDeductions);
            this.groupBox5.Controls.Add(this.lblPremLoans);
            this.groupBox5.Controls.Add(this.labelLoans);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.lblOTPay);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.lblBasicPay);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.lblNetPay);
            this.groupBox5.Controls.Add(this.lblNetGross);
            this.groupBox5.Controls.Add(this.lblAbs);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(568, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 381);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SUMMARY";
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.AutoSize = true;
            this.lblTotalDeductions.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeductions.Location = new System.Drawing.Point(182, 320);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(14, 14);
            this.lblTotalDeductions.TabIndex = 14;
            this.lblTotalDeductions.Text = "-";
            // 
            // lblPremLoans
            // 
            this.lblPremLoans.AutoSize = true;
            this.lblPremLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremLoans.Location = new System.Drawing.Point(182, 293);
            this.lblPremLoans.Name = "lblPremLoans";
            this.lblPremLoans.Size = new System.Drawing.Size(14, 14);
            this.lblPremLoans.TabIndex = 13;
            this.lblPremLoans.Text = "-";
            // 
            // labelLoans
            // 
            this.labelLoans.AutoSize = true;
            this.labelLoans.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoans.Location = new System.Drawing.Point(182, 269);
            this.labelLoans.Name = "labelLoans";
            this.labelLoans.Size = new System.Drawing.Size(14, 14);
            this.labelLoans.TabIndex = 12;
            this.labelLoans.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 320);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 14);
            this.label21.TabIndex = 11;
            this.label21.Text = "Total Deductions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(43, 315);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(230, 2);
            this.panel2.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(41, 293);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 14);
            this.label20.TabIndex = 9;
            this.label20.Text = "Premium Loans";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(97, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 14);
            this.label19.TabIndex = 8;
            this.label19.Text = "Loans";
            // 
            // lblOTPay
            // 
            this.lblOTPay.AutoSize = true;
            this.lblOTPay.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPay.Location = new System.Drawing.Point(182, 129);
            this.lblOTPay.Name = "lblOTPay";
            this.lblOTPay.Size = new System.Drawing.Size(14, 14);
            this.lblOTPay.TabIndex = 7;
            this.lblOTPay.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 14);
            this.label17.TabIndex = 6;
            this.label17.Text = "Overtime Pay";
            // 
            // lblBasicPay
            // 
            this.lblBasicPay.AutoSize = true;
            this.lblBasicPay.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicPay.Location = new System.Drawing.Point(182, 111);
            this.lblBasicPay.Name = "lblBasicPay";
            this.lblBasicPay.Size = new System.Drawing.Size(14, 14);
            this.lblBasicPay.TabIndex = 5;
            this.lblBasicPay.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(69, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 14);
            this.label15.TabIndex = 4;
            this.label15.Text = "Basic Pay";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(182, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 14);
            this.label18.TabIndex = 3;
            this.label18.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(182, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 3;
            this.label13.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(43, 153);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(230, 2);
            this.panel1.TabIndex = 1;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(80, 357);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(14, 14);
            this.lblNetPay.TabIndex = 0;
            this.lblNetPay.Text = "-";
            // 
            // lblNetGross
            // 
            this.lblNetGross.AutoSize = true;
            this.lblNetGross.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetGross.Location = new System.Drawing.Point(182, 161);
            this.lblNetGross.Name = "lblNetGross";
            this.lblNetGross.Size = new System.Drawing.Size(14, 14);
            this.lblNetGross.TabIndex = 0;
            this.lblNetGross.Text = "-";
            // 
            // lblAbs
            // 
            this.lblAbs.AutoSize = true;
            this.lblAbs.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbs.Location = new System.Drawing.Point(182, 246);
            this.lblAbs.Name = "lblAbs";
            this.lblAbs.Size = new System.Drawing.Size(14, 14);
            this.lblAbs.TabIndex = 0;
            this.lblAbs.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Net Pay";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(69, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "Gross Pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Absences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Department";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(113, 33);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(14, 14);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(76, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 14);
            this.label23.TabIndex = 17;
            this.label23.Text = "Job";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(113, 47);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(14, 14);
            this.lblJob.TabIndex = 18;
            this.lblJob.Text = "-";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 463);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblNetGross;
        private System.Windows.Forms.Label lblAbs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOTPay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBasicPay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelLoans;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPremLoans;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label10;


    }
}