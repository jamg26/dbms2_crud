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
        public FillForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.activeForm = comboBox1.Text;
            if (this.activeForm == "tb_info")
            {
                grp_tbinfo.Visible = true;
                grp_tbdept.Visible = false;
                grp_tbjob.Visible = false;
            }
            if (this.activeForm == "tb_department")
            {
                grp_tbinfo.Visible = false;
                grp_tbdept.Visible = true;
                grp_tbjob.Visible = false;
            }
            if (this.activeForm == "tb_job")
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

            if (this.activeForm == "tb_info") {
                db.dbInsert("INSERT INTO tb_info (lastname, firstname, middlename, address, birthdate, birthplace, contact, department, job) VALUES ('" + txtLN.Text + "', '" + txtFN.Text + "', '" + txtMN.Text + "', '" + txtAdd.Text + "', '" + txtBDate.Text + "', '" + txtBPlace.Text + "', '" + txtContact.Text + "', " + Convert.ToInt32(cmbDept.SelectedIndex + 1) + ", " + Convert.ToInt32(cmbJob.SelectedIndex + 1) + ")");
                MessageBox.Show("Added!");
            }
        }
    }
}
