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
    public partial class AddToWatchList : Form
    {
        List<int> ayesm;
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public AddToWatchList()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void AddToWatchList_Load(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            ayesm = new List<int>();
            comm.CommandText = "select WatchListName,ListID from WatchList where UserID =:ID";
            comm.Parameters.Add("ID", Form1.global1);
            OracleDataReader dr = comm.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                ayesm.Add(Convert.ToInt32(dr[1]));
            }
            dr.Close();

        }

        private void Addto_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;

            comm.CommandText = "insert into WatchListContent values(:ListID,:ContentID,:ContentName)";
            comm.Parameters.Add("ListID", ayesm[comboBox1.SelectedIndex]);
            comm.Parameters.Add("ContentID", Content.global4.ElementAt(Content.global3).Value);
            comm.Parameters.Add("ContentName", Content.global4.ElementAt(Content.global3).Key);
            comm.ExecuteNonQuery();
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select max (ListID) from WatchList";
            int count = Convert.ToInt32(comm.ExecuteScalar());
            comm.CommandText = "insert into WatchList values(:ListID,:UserID,:WatchListName)";
            comm.Parameters.Add("ListID", count + 1);
            comm.Parameters.Add("UserID", Form1.global1);
            comm.Parameters.Add("WatchListName", textBox1.Text);
            comm.ExecuteNonQuery();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stepback_Click(object sender, EventArgs e)
        {
            Content con = new Content();
            con.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
