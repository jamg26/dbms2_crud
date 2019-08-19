using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms2_crud {
    public partial class Main : Form {
        string activeTab = "Information";
        int del_id;
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
            delBtn.Enabled = false;
            getInfoData();
            getDeptData();
            getJobData();
            getEmployee();
        }

        private void getInfoData()
        {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect("SELECT * FROM tb_info ORDER BY id DESC");
            dataGridView1.DataSource = dt;
        }

        private void getDeptData()
        {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect("SELECT * FROM tb_department ORDER BY id DESC");
            dataGridView3.DataSource = dt;
        }
        private void getJobData()
        {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect("SELECT * FROM tb_job ORDER BY id DESC");
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillForm form = new FillForm();
            form.getDept();
            form.getJob();
            form.btnAdd.Visible = true;
            form.btnUpdate.Visible = false;
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                delBtn.Enabled = true;
                this.del_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void tabtool1_Selected(object sender, TabControlEventArgs e)
        {
            this.activeTab = tabtool1.SelectedTab.Text;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Selected entry will be deleted", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK)) {
                dbClass db = new dbClass();
                if (this.activeTab == "Information") {
                    db.dbDelete("DELETE FROM tb_info WHERE id=" + this.del_id);
                }
                if (this.activeTab == "Department") {
                    db.dbDelete("DELETE FROM tb_department WHERE id=" + this.del_id);
                }
                if (this.activeTab == "Job") {
                    db.dbDelete("DELETE FROM tb_job WHERE id=" + this.del_id);
                }
                if (this.activeTab == "Employee") {
                    db.dbDelete("DELETE FROM tb_employee WHERE id=" + this.del_id);
                }
                getInfoData();
                getDeptData();
                getJobData();
                getEmployee();
                MessageBox.Show("DELETED!");
            } else { }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DialogResult result = MessageBox.Show("Click YES to edit info press NO to print.", "Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.No)) {
                Print_Ind ind = new Print_Ind();
                ind.id = this.del_id;
                ind.Show();
            } else {
                dbClass db = new dbClass();
                DataTable jb = db.dbSelect("SELECT description from tb_job WHERE id=" + dataGridView1.CurrentRow.Cells[9].Value.ToString());
                DataTable dp = db.dbSelect("SELECT code from tb_department WHERE id=" + dataGridView1.CurrentRow.Cells[8].Value.ToString());
                FillForm form = new FillForm();
                form.getDept();
                form.getJob();
                if (this.activeTab == "Information") {
                    form.comboBox1.Text = "Information";
                    form.txtLN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    form.txtFN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    form.txtMN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    form.txtAdd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    form.pickBday.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    form.txtBPlace.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    form.txtContact.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    form.cmbDept.Text = dp.Rows[0][0].ToString();
                    form.cmbJob.Text = jb.Rows[0][0].ToString();
                    form.btnUpdate.Visible = true;
                    form.btnAdd.Visible = false;
                    form.activeID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    form.Show();
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                delBtn.Enabled = true;
                this.del_id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            FillForm form = new FillForm();
            if (this.activeTab == "Department") {
                form.comboBox1.Text = "Department";
                form.btnUpdate.Visible = true;
                form.btnAdd.Visible = false;
                form.txtCode.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                form.txtDesc.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                form.activeID = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                form.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                delBtn.Enabled = true;
                this.del_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            dbClass db = new dbClass();
            DataTable parent = db.dbSelect("SELECT code from tb_department WHERE id=" + dataGridView2.CurrentRow.Cells[2].Value.ToString());
            FillForm form = new FillForm();
            form.getDept();
            if (this.activeTab == "Job") {
                form.comboBox1.Text = "Job";
                form.btnUpdate.Visible = true;
                form.btnAdd.Visible = false;
                form.activeID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                form.txtJob.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                form.cmbParent.Text = parent.Rows[0][0].ToString();
                form.txtSalary.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                this.Hide();
                form.Show();
            }
        }

        private void getEmployee() {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect("SELECT * FROM tb_employee ORDER BY id DESC");
            dataGridView4.DataSource = dt;
        }

        private void calcIncome(int days, double gross, double overtime, int absences, double loans, double netpay) {
            dbClass db = new dbClass();
            DataTable getJob = db.dbSelect("SELECT job from tb_info WHERE id=" + this.del_id);
            DataTable getJobs = db.dbSelect("SELECT salary from tb_job where id=" + getJob.Rows[0][0]);
            MessageBox.Show(getJobs.Rows[0][0].ToString());
        }

        private void button2_Click(object sender, EventArgs e) {
            Income inc = new Income();
            this.Hide();
            inc.Show();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                delBtn.Enabled = true;
                this.del_id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e) {
            new Print_Info().Show();
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DialogResult result = MessageBox.Show("Print payslip?", "PAYSLIP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK)) {
                Print_payslip pay = new Print_payslip();
                pay.id = this.del_id;
                pay.Show();
            
            } else {

            }
            
        }
    }
}
