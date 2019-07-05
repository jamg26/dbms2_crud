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
            }
            if (this.activeForm == "tb_department") {
                db.dbInsert("INSERT INTO tb_department (code, description) VALUES ('" + txtCode.Text + "', '" + txtDesc.Text + "')");
            }
            if (this.activeForm == "tb_job") {
                db.dbInsert("INSERT INTO tb_job (description) VALUES ('" + txtJob.Text + "')");
            }
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            dbClass db = new dbClass();
            if (this.activeForm == "tb_info") {
                db.dbUpdate("UPDATE tb_info SET lastname='" + txtLN.Text + "', firstname='" + txtFN.Text + "', middlename='" + txtMN.Text + "', address='" + txtAdd.Text + "', birthdate='" + txtBDate.Text + "', birthplace='" + txtBPlace.Text + "', contact='" + txtContact.Text + "', department='" + Convert.ToInt32(cmbDept.SelectedIndex + 1) + "', job='" + Convert.ToInt32(cmbJob.SelectedIndex + 1) + "' WHERE id=" + this.activeID);
            }
            if (this.activeForm == "tb_department") {
                db.dbUpdate("UPDATE tb_department SET code='" + txtCode.Text + "', description='" + txtDesc.Text + "' WHERE id=" + this.activeID);
            }
            if (this.activeForm == "tb_job") { 
                db.dbUpdate("UPDATE tb_job SET description='" + txtJob.Text + "' WHERE id=" + this.activeID);
            }
            MessageBox.Show("Updated!");
        }
    }
}
