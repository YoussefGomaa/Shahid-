using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace user
{
    public partial class CheckWatchList : Form
    {
        Watchlists WL;
        public CheckWatchList()
        {
            InitializeComponent();
        }

        private void CheckWatchList_Load(object sender, EventArgs e)
        {
            WL = new Watchlists();
            foreach (ParameterDiscreteValue v in WL.ParameterFields[0].DefaultValues)
                CBListID.Items.Add(v.Value);
        }

        private void loadwatchlist_Click(object sender, EventArgs e)
        {
            WL.SetParameterValue(0, CBListID.Text);
            crystalReportViewer1.ReportSource = WL;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void stepback_Click(object sender, EventArgs e)
        {
            Content content1 = new Content();
            content1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
