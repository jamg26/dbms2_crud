using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms2_crud
{
    public partial class FillForm : Form
    {
        string activeForm;
        public string activeID;
        public FillForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.activeForm = comboBox1.Text;
            if (this.activeForm == "Information")
            {
                grp_tbinfo.Visible = true;
                grp_tbdept.Visible = false;
                grp_tbjob.Visible = false;
            }
            if (this.activeForm == "Department")
            {
                grp_tbinfo.Visible = false;
                grp_tbdept.Visible = true;
                grp_tbjob.Visible = false;
            }
            if (this.activeForm == "Job")
            {
                grp_tbinfo.Visible = false;
                grp_tbdept.Visible = false;
                grp_tbjob.Visible = true;
            }
        }

        private void FillForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            DataTable dt_job = new DataTable();
            DataTable dt_dept = new DataTable();
            dt_job = db.dbSelect("SELECT id FROM tb_job WHERE description='" + cmbJob.Text + "'");
            dt_dept = db.dbSelect("SELECT id FROM tb_department WHERE code='" + cmbDept.Text + "'");
            DataTable parent = db.dbSelect("SELECT id from tb_department WHERE code='" + cmbParent.Text + "'");
            if (this.activeForm == "Information") {
                db.dbInsert("INSERT INTO tb_info (lastname, firstname, middlename, address, birthdate, birthplace, contact, department, job) VALUES ('" + txtLN.Text + "', '" + txtFN.Text + "', '" + txtMN.Text + "', '" + txtAdd.Text + "', '" + pickBday.Text + "', '" + txtBPlace.Text + "', '" + txtContact.Text + "', " + Convert.ToInt32(dt_dept.Rows[0][0]) + ", " + Convert.ToInt32(dt_job.Rows[0][0]) + ")");
            }
            if (this.activeForm == "Department") {
                db.dbInsert("INSERT INTO tb_department (code, description) VALUES ('" + txtCode.Text + "', '" + txtDesc.Text + "')");
            }
            if (this.activeForm == "Job") {
                db.dbInsert("INSERT INTO tb_job (description, parent, salary) VALUES ('" + txtJob.Text + "', " + parent.Rows[0][0] + ", " + txtSalary.Text + ")");
            }
            Main main = new Main();
            this.Hide();
            main.Show();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            dbClass db = new dbClass();
            DataTable jb = db.dbSelect("SELECT id from tb_job WHERE description='" + cmbJob.Text + "'");
            DataTable dp = db.dbSelect("SELECT id from tb_department WHERE code='" + cmbDept.Text + "'");
            DataTable parent = db.dbSelect("SELECT id from tb_department WHERE code='" + cmbParent.Text + "'");
            if (this.activeForm == "Information") {
                db.dbUpdate("UPDATE tb_info SET lastname='" + txtLN.Text + "', firstname='" + txtFN.Text + "', middlename='" + txtMN.Text + "', address='" + txtAdd.Text + "', birthdate='" + pickBday.Text + "', birthplace='" + txtBPlace.Text + "', contact='" + txtContact.Text + "', department=" + dp.Rows[0][0].ToString() + ", job=" + jb.Rows[0][0].ToString() + " WHERE id=" + this.activeID);
            }
            if (this.activeForm == "Department") {
                db.dbUpdate("UPDATE tb_department SET code='" + txtCode.Text + "', description='" + txtDesc.Text + "' WHERE id=" + this.activeID);
            }
            if (this.activeForm == "Job") {
                db.dbUpdate("UPDATE tb_job SET description='" + txtJob.Text + "', parent=" + parent.Rows[0][0] + ", salary=" + txtSalary.Text + " WHERE id=" + this.activeID);
            }
            Main main = new Main();
            this.Hide();
            main.Show();
            MessageBox.Show("Updated!");
        }

        public void getDept() {
            DataTable dt = new DataTable();
            dbClass db = new dbClass();
            dt = db.dbSelect("SELECT * FROM tb_department");
            for (int i = 0; i < dt.Rows.Count; i++) {
                cmbDept.Items.Add(dt.Rows[i]["code"]);
                cmbParent.Items.Add(dt.Rows[i]["code"]);
            }
        }

        public void getJob() {
            DataTable dt = new DataTable();
            dbClass db = new dbClass();
            DataTable parent = db.dbSelect("SELECT id from tb_department WHERE code='" + cmbDept.Text + "'");
            try {
                dt = db.dbSelect("SELECT * FROM tb_job WHERE parent=" + parent.Rows[0][0]);
            } catch { }
            for (int i = 0; i < dt.Rows.Count; i++) {
                cmbJob.Items.Add(dt.Rows[i]["description"]);
            }
        }


        private void FillForm_FormClosed(object sender, FormClosedEventArgs e) {
            Main mm = new Main();
            mm.Show();
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e) {
            cmbJob.Items.Clear();
            lblSal.Text = "0";
            getJob();
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e) {
            dbClass db = new dbClass();
            DataTable sal = db.dbSelect("select salary from tb_job where description='" + cmbJob.Text + "'");
            lblSal.Text = sal.Rows[0][0].ToString();
        }
    }
}
