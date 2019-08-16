using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms2_crud {
    public partial class Print_payslip : Form {
        public int id;
        public Print_payslip() {
            InitializeComponent();
        }

        private void Print_payslip_Load(object sender, EventArgs e) {
            crystalReportViewer1.SelectionFormula = "{tb_employee.id} = " + id;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
