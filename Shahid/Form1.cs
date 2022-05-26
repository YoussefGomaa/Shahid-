using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace user
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static int global1;
        private void Login_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = Password.Text;
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM ShahidUser where UserName='" + username.Text + "' AND UserPass='" + Password.Text + "'"; 
            OracleDataReader dr=comm.ExecuteReader();
            if (username.Text == "Ashour" && Password.Text == "1234")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (dr.Read())
            {
               MessageBox.Show("done");
               Shahid sh = new Shahid();
               sh.Show();
               this.Hide();
            }
            comm.CommandText = "userdetails";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("username", username.Text);
            comm.Parameters.Add("ID", OracleDbType.Int32,ParameterDirection.Output);
            comm.ExecuteNonQuery();
            int id = Convert.ToInt32(comm.Parameters["ID"].Value.ToString());
            comm.CommandText = "select * from ShahidUser where ID=:UserID";
            comm.Parameters.Add("ID", id);
            global1 = id;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
           
            Register Reg = new Register();
            Reg.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
