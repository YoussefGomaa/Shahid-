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
    public partial class Userdetails : Form
    {   
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Userdetails()
        {
            InitializeComponent();
        }

        private void Userdetails_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from ShahidUser where UserID =: global1 ";
            comm.Parameters.Add("global1", Form1.global1);
            OracleDataReader dr=comm.ExecuteReader();
            if (dr.Read())
            {
                var username1=dr["UserName"].ToString();
                var UserPass = dr["UserPass"].ToString();
                var fname = dr["FirstName"].ToString();
                var lname = dr["LastName"].ToString();
                var email = dr["Email"].ToString();
                username.Text = username1;
                password.Text = UserPass;
                Fname.Text = fname;
                Lname.Text = lname;
                Email.Text = email;

            }
            dr.Close();
        }

        private void stepback_Click(object sender, EventArgs e)
        {
            Shahid sh = new Shahid();
            sh.Show();
            this.Hide();
        }
    }
}
