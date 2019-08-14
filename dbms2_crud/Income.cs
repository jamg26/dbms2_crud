using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms2_crud {
    public partial class Income : Form {
        int id;
        decimal salary, net_pay, gross_pay;
        public Income() {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e) {
            this.AcceptButton = btnAdd;
            dbClass db = new dbClass();
            DataTable dt = db.dbSelect("SELECT * FROM tb_info");
            for (int i = 0; i < dt.Rows.Count; i++) {
                cmbEmployees.Items.Add(dt.Rows[i]["firstname"].ToString() + " " + dt.Rows[i]["lastname"].ToString());
            }
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e) {
            DataTable id, job, salary;
            txtNetGross.Text = "";
            dbClass db = new dbClass();
            String[] name = cmbEmployees.Text.Split(' ');
            id = db.dbSelect("select id from tb_info where firstname='" + name[0] + "' and lastname ='" + name[1] + "'");
            this.id = Convert.ToInt32(id.Rows[0][0]);
            job = db.dbSelect("select job from tb_info where id=" + this.id);
            salary = db.dbSelect("select salary from tb_job where id=" + job.Rows[0][0]);
            this.salary = Convert.ToDecimal(salary.Rows[0][0]);
            txtSalary.Text = salary.Rows[0][0].ToString();
            try {
                calcGross(Convert.ToDecimal(salary.Rows[0][0]), Convert.ToInt32(numWorkDays.Value), Convert.ToInt32(numOT.Value));
                calcNet(Convert.ToInt32(numAbsent.Value), Convert.ToDecimal(txtLoans.Text));
            } catch { }
        }

        private void numWorkDays_ValueChanged(object sender, EventArgs e) {
            try {
                calcGross(Convert.ToDecimal(this.salary), Convert.ToInt32(numWorkDays.Value), Convert.ToInt32(numOT.Value));
                calcNet(Convert.ToInt32(numAbsent.Value), Convert.ToDecimal(txtLoans.Text));
            } catch { }
        }

        private void numOT_ValueChanged(object sender, EventArgs e) {
            try {
                calcGross(Convert.ToDecimal(this.salary), Convert.ToInt32(numWorkDays.Value), Convert.ToInt32(numOT.Value));
                calcNet(Convert.ToInt32(numAbsent.Value), Convert.ToDecimal(txtLoans.Text));
            } catch { }        }

        private void calcGross(decimal salary, int workDays, int ot) {
            this.gross_pay = (salary * workDays) + (ot * 40);
            txtNetGross.Text = this.gross_pay.ToString();
            lblNetGross.Text = this.gross_pay.ToString();
        }

        private void calcNet(int absences, decimal loans) { 
            this.net_pay = (this.gross_pay - (this.salary * numAbsent.Value)) - loans;
            txtNetPay.Text = this.net_pay.ToString();
            lblLoans.Text = loans.ToString();
            lblAbs.Text = (this.salary * numAbsent.Value).ToString();
            lblNetPay.Text = this.net_pay.ToString();
        }

        private void numAbsent_ValueChanged(object sender, EventArgs e) {
            try {
                calcNet(Convert.ToInt32(numAbsent.Value), Convert.ToDecimal(txtLoans.Text));
            } catch { }
        }

        private void txtLoans_TextChanged(object sender, EventArgs e) {
            try {
                calcNet(Convert.ToInt32(numAbsent.Value), Convert.ToDecimal(txtLoans.Text));
            } catch { }
            calcTotalLoans();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (this.txtNetPay.Text != "0.00") {
                dbClass db = new dbClass();
                DateTime date = DateTime.Now;
                String query = "insert into tb_employees (fullname, no_of_days, gross_income, overtime_hrs, no_of_absences, loans, net_pay, date) values ('" + cmbEmployees.Text + "', " + numWorkDays.Value + ", " + this.gross_pay + ", " + numOT.Value + ", " + numAbsent.Value + ", " + txtLoans.Text + ", " + txtNetPay.Text + ", '" + date + "')";
                db.dbInsert(query);
                Main main = new Main();
                this.Hide();
                main.Show();
                MessageBox.Show("Record added!");
            } else {
                MessageBox.Show("Please fill all forms!");
            }
        }

        private void Income_FormClosed(object sender, FormClosedEventArgs e) {
            Main main = new Main();
            main.Show();
        }

        private void checkPagibig_CheckedChanged(object sender, EventArgs e) {
            txtPagibigLoans.Enabled = checkPagibig.Checked;
            if (!txtPagibigLoans.Enabled) {
                txtPagibigLoans.Text = "0.00";
            }
        }

        private void checkSSS_CheckedChanged(object sender, EventArgs e) {
            txtSSSLoans.Enabled = checkSSS.Checked;
            if (!txtSSSLoans.Enabled) {
                txtSSSLoans.Text = "0.00";
            }
        }

        private void checkOther_CheckedChanged(object sender, EventArgs e) {
            txtOtherLoans.Enabled = checkOther.Checked;
            txtOtherLoansName.Enabled = checkOther.Checked;
            if (!txtOtherLoans.Enabled) {
                txtOtherLoans.Text = "0.00";
                txtOtherLoansName.Text = "Name";
            }
        }

        private void txtPagibigLoans_Enter(object sender, EventArgs e) {
            txtPagibigLoans.Text = "";
        }

        private void txtSSSLoans_Enter(object sender, EventArgs e) {
            txtSSSLoans.Text = "";
        }

        private void txtOtherLoansName_Enter(object sender, EventArgs e) {
            txtOtherLoansName.Text = "";
        }

        private void txtOtherLoans_Enter(object sender, EventArgs e) {
            txtOtherLoans.Text = "";
        }

        private void txtSalary_Enter(object sender, EventArgs e) {
            txtSalary.Text = "";
        }

        private void calcTotalLoans() {
            decimal total_loans;
            try {
                total_loans = Convert.ToDecimal(txtPagibigLoans.Text) + Convert.ToDecimal(txtSSSLoans.Text) + Convert.ToDecimal(txtOtherLoans.Text) + Convert.ToDecimal(txtPremPagibig.Text) + Convert.ToDecimal(txtPremPhil.Text) + Convert.ToDecimal(txtPremSSS.Text);
                txtLoans.Text = total_loans.ToString();
            } catch { }
        }

        private void txtPagibigLoans_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtSSSLoans_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtOtherLoans_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtPremPagibig_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtPremPhil_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtPremSSS_TextChanged(object sender, EventArgs e) {
            calcTotalLoans();
        }

        private void txtPremPagibig_Enter(object sender, EventArgs e) {
            txtPremPagibig.Text = "";
        }

        private void txtPremPhil_Enter(object sender, EventArgs e) {
            txtPremPhil.Text = "";
        }

        private void txtPremSSS_Enter(object sender, EventArgs e) {
            txtPremSSS.Text = "";
        }

        

       
    }
}
