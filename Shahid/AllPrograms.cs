using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user
{
    public partial class AllPrograms : Form
    {
        ContentActors CA;
        public AllPrograms()
        {
            InitializeComponent();
        }

        private void AllPrograms_Load(object sender, EventArgs e)
        {
            CA = new ContentActors();
        }

        private void Genrate_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CA;
        }

        private void stepback_Click(object sender, EventArgs e)
        {
            Content cont = new Content();
            cont.Show();
            this.Hide();
        }
    }
}
