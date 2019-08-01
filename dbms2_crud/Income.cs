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
        }

        private void calcNet(int absences, decimal loans) { 
            this.net_pay = (this.gross_pay - (this.salary * numAbsent.Value)) - loans;
            txtNetPay.Text = this.net_pay.ToString();
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
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            dbClass db = new dbClass();
            DateTime date = DateTime.Now;
            String query = "insert into tb_employees (fullname, no_of_days, gross_income, overtime_hrs, no_of_absences, loans, net_pay, date) values ('" + cmbEmployees.Text + "', " + numWorkDays.Value + ", " + this.gross_pay + ", " + numOT.Value + ", " + numAbsent.Value + ", " + txtLoans.Text + ", " + txtNetPay.Text + ", '" + date + "')";
            db.dbInsert(query);
            Main main = new Main();
            this.Hide();
            main.Show();
            MessageBox.Show("Record added!");
        }

        private void Income_FormClosed(object sender, FormClosedEventArgs e) {
            Main main = new Main();
            main.Show();
        }
    }
}
