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
    public partial class Content : Form
    {
        public static int global3;
        public static Dictionary<string, int> global4;
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Content()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        public static string global2;
        private void Content_Load(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;

            comm.CommandText = "showcontent";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("ContentName", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = comm.ExecuteReader();
            global4 = new Dictionary<string, int>();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                global4.Add(dr[0].ToString(), Convert.ToInt32(dr[1]));
            }
            dr.Close();
        }

        private void contdetails_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;

            comm.CommandText = "select GenreType,CategoryType from shahidcontent where ContentName=:name";
            comm.Parameters.Add("name", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = comm.ExecuteReader();
            if(dr.Read())
            {
                genrebox.Text = dr[0].ToString();
                catbox.Text = dr[1].ToString();
            }
        }

        private void stepback_Click(object sender, EventArgs e)
        {
            Shahid sh = new Shahid();
            sh.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tocrystalcont_Click(object sender, EventArgs e)
        {
            AllPrograms prgs = new AllPrograms();
            prgs.Show();
            this.Hide();
        }

        private void addtoWL_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            AddToWatchList atw = new AddToWatchList();
            atw.Show();
            this.Hide();
            global3 = comboBox1.SelectedIndex;
        }

        private void towatchlists_Click(object sender, EventArgs e)
        {
            CheckWatchList CWL = new CheckWatchList();
            CWL.Show();
            this.Hide();
        }
    }
}
