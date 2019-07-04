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
        string activeTab;
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
            dataGridView2.DataSource = dt;
        }
        private void getJobData()
        {
            dbClass db = new dbClass();
            System.Data.DataTable dt = db.dbSelect("SELECT * FROM tb_job ORDER BY id DESC");
            dataGridView3.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillForm form = new FillForm();
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.del_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void tabtool1_Selected(object sender, TabControlEventArgs e)
        {
            this.activeTab = tabtool1.SelectedTab.Text;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            dbClass db = new dbClass();
            db.dbDelete("DELETE FROM tb_info WHERE id=" + this.del_id);
            MessageBox.Show("DELETED!");
        }

    }
}
