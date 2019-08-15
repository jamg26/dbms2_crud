using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms2_crud {
    public partial class Print_Ind : Form {
        public int id;
        public Print_Ind() {
            InitializeComponent();
        }

        private void Print_Ind_Load(object sender, EventArgs e) {
            crystalReportViewer1.SelectionFormula = "{tb_info.id} = " + id;
        }
    }
}
