using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace dbms2_crud {
    class dbClass {
        SqlConnection connect = getConnection();

        public static SqlConnection getConnection() {
            string dbServer = "dbms.cohc7bcuo0vm.ap-southeast-1.rds.amazonaws.com";
            string dbName = "dbms_galicia";
            string dbUser = "admin";
            SqlConnection conn = new SqlConnection("Data Source = " + dbServer + "; Initial Catalog = " + dbName + "; User ID=" + dbUser + ";Password=amazonrds;");
            return conn;
        }

        public void dbInsert(string query) {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.InsertCommand = new SqlCommand(query, connect);
            connect.Open();
            sda.InsertCommand.ExecuteNonQuery();
            connect.Close();
        }

        public void dbUpdate(string query) {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.UpdateCommand = new SqlCommand(query, connect);
            connect.Open();
            sda.UpdateCommand.ExecuteNonQuery();
            connect.Close();
        }

        public void dbDelete(string query) {
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.UpdateCommand = new SqlCommand(query, connect);
            connect.Open();
            sda.UpdateCommand.ExecuteNonQuery();
            connect.Close();
        }

        public System.Data.DataTable dbSelect(string query) {
            connect.Open();
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            return dt;
        }
    }
}
