namespace dbms2_crud
{
    partial class FillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.txtBPlace = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_tbinfo = new System.Windows.Forms.GroupBox();
            this.grp_tbdept = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grp_tbjob = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grp_tbinfo.SuspendLayout();
            this.grp_tbdept.SuspendLayout();
            this.grp_tbjob.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "tb_info",
            "tb_department",
            "tb_job"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(23, 43);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(171, 20);
            this.txtFN.TabIndex = 1;
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(23, 84);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(171, 20);
            this.txtMN.TabIndex = 2;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(23, 124);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(171, 20);
            this.txtLN.TabIndex = 3;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(23, 163);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(171, 20);
            this.txtAdd.TabIndex = 4;
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(23, 200);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.Size = new System.Drawing.Size(171, 20);
            this.txtBDate.TabIndex = 5;
            // 
            // txtBPlace
            // 
            this.txtBPlace.Location = new System.Drawing.Point(274, 43);
            this.txtBPlace.Name = "txtBPlace";
            this.txtBPlace.Size = new System.Drawing.Size(171, 20);
            this.txtBPlace.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(274, 84);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(171, 20);
            this.txtContact.TabIndex = 7;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "HRD",
            "ACCOUNTING"});
            this.cmbDept.Location = new System.Drawing.Point(274, 124);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 21);
            this.cmbDept.TabIndex = 8;
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "STAFF",
            "ACCOUNTING HEAD"});
            this.cmbJob.Location = new System.Drawing.Point(274, 162);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(121, 21);
            this.cmbJob.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(396, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Birth Place";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Job Title";
            // 
            // grp_tbinfo
            // 
            this.grp_tbinfo.Controls.Add(this.label1);
            this.grp_tbinfo.Controls.Add(this.label9);
            this.grp_tbinfo.Controls.Add(this.txtFN);
            this.grp_tbinfo.Controls.Add(this.label8);
            this.grp_tbinfo.Controls.Add(this.txtMN);
            this.grp_tbinfo.Controls.Add(this.label7);
            this.grp_tbinfo.Controls.Add(this.txtLN);
            this.grp_tbinfo.Controls.Add(this.label6);
            this.grp_tbinfo.Controls.Add(this.txtAdd);
            this.grp_tbinfo.Controls.Add(this.label5);
            this.grp_tbinfo.Controls.Add(this.txtBDate);
            this.grp_tbinfo.Controls.Add(this.label4);
            this.grp_tbinfo.Controls.Add(this.txtBPlace);
            this.grp_tbinfo.Controls.Add(this.label3);
            this.grp_tbinfo.Controls.Add(this.txtContact);
            this.grp_tbinfo.Controls.Add(this.label2);
            this.grp_tbinfo.Controls.Add(this.cmbDept);
            this.grp_tbinfo.Controls.Add(this.cmbJob);
            this.grp_tbinfo.Location = new System.Drawing.Point(26, 44);
            this.grp_tbinfo.Name = "grp_tbinfo";
            this.grp_tbinfo.Size = new System.Drawing.Size(470, 239);
            this.grp_tbinfo.TabIndex = 20;
            this.grp_tbinfo.TabStop = false;
            this.grp_tbinfo.Text = "tb_info";
            this.grp_tbinfo.Visible = false;
            // 
            // grp_tbdept
            // 
            this.grp_tbdept.Controls.Add(this.label11);
            this.grp_tbdept.Controls.Add(this.label10);
            this.grp_tbdept.Controls.Add(this.textBox2);
            this.grp_tbdept.Controls.Add(this.textBox1);
            this.grp_tbdept.Location = new System.Drawing.Point(26, 44);
            this.grp_tbdept.Name = "grp_tbdept";
            this.grp_tbdept.Size = new System.Drawing.Size(470, 239);
            this.grp_tbdept.TabIndex = 21;
            this.grp_tbdept.TabStop = false;
            this.grp_tbdept.Text = "tb_department";
            this.grp_tbdept.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Code";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            // 
            // grp_tbjob
            // 
            this.grp_tbjob.Controls.Add(this.label12);
            this.grp_tbjob.Controls.Add(this.txtJob);
            this.grp_tbjob.Location = new System.Drawing.Point(26, 44);
            this.grp_tbjob.Name = "grp_tbjob";
            this.grp_tbjob.Size = new System.Drawing.Size(470, 239);
            this.grp_tbjob.TabIndex = 22;
            this.grp_tbjob.TabStop = false;
            this.grp_tbjob.Text = "tb_job";
            this.grp_tbjob.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Job Title";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(23, 43);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(171, 20);
            this.txtJob.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(396, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grp_tbinfo);
            this.Controls.Add(this.grp_tbjob);
            this.Controls.Add(this.grp_tbdept);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Name = "FillForm";
            this.Text = "FillForm";
            this.Load += new System.EventHandler(this.FillForm_Load);
            this.grp_tbinfo.ResumeLayout(false);
            this.grp_tbinfo.PerformLayout();
            this.grp_tbdept.ResumeLayout(false);
            this.grp_tbdept.PerformLayout();
            this.grp_tbjob.ResumeLayout(false);
            this.grp_tbjob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grp_tbinfo;
        private System.Windows.Forms.GroupBox grp_tbdept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grp_tbjob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtJob;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtFN;
        public System.Windows.Forms.TextBox txtMN;
        public System.Windows.Forms.TextBox txtLN;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtBDate;
        public System.Windows.Forms.TextBox txtBPlace;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.ComboBox cmbDept;
        public System.Windows.Forms.ComboBox cmbJob;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
    }
}