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
    public partial class Admin : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder1;
        DataSet DS;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {

        }

        private void loading_Click_1(object sender, EventArgs e)
        {
            string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
            string cmd = "";
            if (Users.Checked)
                cmd = "select * from ShahidUser";
            else if (Content.Checked)
                cmd = "select * from ShahidContent";
            
            adapter = new OracleDataAdapter(cmd, ordb);
            DS = new DataSet();
            adapter.Fill(DS);
            DGV.DataSource = DS.Tables[0];
        }

        private void Save_Click(object sender, EventArgs e)
        {
            builder1 = new OracleCommandBuilder(adapter);
            adapter.Update(DS.Tables[0]);
        }

        private void stepback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
                   
}
    

