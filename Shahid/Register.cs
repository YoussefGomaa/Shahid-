using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace user
{
    public partial class Register : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();

            comm.Connection = conn;
            comm.CommandText = "select max (UserID) from ShahidUser";
            int count = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = "INSERT into ShahidUser values(:userID,:UserName,:UserPass,:FirstName,:LastName,:Email)";
            comm.Parameters.Add("ID", count + 1);
            comm.Parameters.Add("username",username.Text);
            comm.Parameters.Add("password",password.Text);
            comm.Parameters.Add("Fname",Fname.Text);
            comm.Parameters.Add("Lname",Lname.Text);
            comm.Parameters.Add("Email",Email.Text);
            bool valid = true;

            try
            {
                int r = comm.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                      + @"([-a-z0-9!#$%&amp;'*+/=?^_`{|}~]|(?&lt;!\.)\.)*)(?&lt;!\.)"
                                      + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                valid = false;
                
                if (username.Text==String.Empty)
                {
                    username.BackColor = Color.LightPink;
                    username.Focus();
                    MessageBox.Show("Fill your Username");
                }
                if (password.Text == String.Empty)
                {
                    password.BackColor = Color.LightPink;
                    username.Focus();
                    MessageBox.Show("Fill your Password");
                }
                if (Fname.Text == String.Empty)
                {
                    Fname.BackColor = Color.LightPink;
                    username.Focus();
                    MessageBox.Show("Fill your FirstName");
                }
                if (Lname.Text == String.Empty)
                {
                    Lname.BackColor = Color.LightPink;
                    username.Focus();
                    MessageBox.Show("Fill your LastName");
                }
                if (Email.Text == String.Empty)
                {
                    username.BackColor = Color.LightPink;
                    username.Focus();
                    MessageBox.Show("Fill your Email");
                }

            }
                if (valid)
                {
                    MessageBox.Show("Register Complete!! Now Login");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                   
                    return;
                }
                
           
        }
    }  
}
