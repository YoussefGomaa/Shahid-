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
    public partial class Shahid : Form
    {
        public Shahid()
        {
            InitializeComponent();
        }

        private void Shahid_Load(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Userdetails details = new Userdetails();
            details.Show();
            this.Hide();
        }

        private void ShowContent_Click(object sender, EventArgs e)
        {
            Content contents = new Content();
            contents.Show();
            this.Hide();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
