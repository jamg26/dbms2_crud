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
        string activeTab = "tb_info";
        int del_id;
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            getInfoData();
            getDeptData();
            getJobData();
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
            form.btnAdd.Visible = true;
            form.btnUpdate.Visible = false;
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                this.del_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void tabtool1_Selected(object sender, TabControlEventArgs e)
        {
            this.activeTab = tabtool1.SelectedTab.Text;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            if (this.activeTab == "tb_info") {
                db.dbDelete("DELETE FROM tb_info WHERE id=" + this.del_id);
            }
            if (this.activeTab == "tb_department") {
                db.dbDelete("DELETE FROM tb_department WHERE id=" + this.del_id);
            }
            if (this.activeTab == "tb_job") {
                db.dbDelete("DELETE FROM tb_job WHERE id=" + this.del_id);
            }
            MessageBox.Show("DELETED!");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            FillForm form = new FillForm();
            if (this.activeTab == "tb_info") {
                form.comboBox1.Text = "tb_info";
                form.txtLN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                form.txtFN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form.txtMN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                form.txtAdd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                form.txtBDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                form.txtBPlace.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                form.txtContact.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                form.cmbDept.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                form.cmbJob.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                form.btnUpdate.Visible = true;
                form.btnAdd.Visible = false;
                form.activeID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                form.Show();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                this.del_id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            FillForm form = new FillForm();
            if (this.activeTab == "tb_department") {
                form.comboBox1.Text = "tb_department";
                form.btnUpdate.Visible = true;
                form.btnAdd.Visible = false;
                form.txtCode.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                form.txtDesc.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                form.activeID = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                form.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                this.del_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            } catch { }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            FillForm form = new FillForm();
            if (this.activeTab == "tb_job") {
                form.comboBox1.Text = "tb_job";
                form.btnUpdate.Visible = true;
                form.btnAdd.Visible = false;
                form.txtJob.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                form.activeID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                form.Show();
            }
        }
    }
}
