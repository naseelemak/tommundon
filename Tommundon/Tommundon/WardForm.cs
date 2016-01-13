using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tommundon
{
    public partial class WardForm : UserControl
    {
        public WardForm()
        {
            InitializeComponent();
            NoNursesTextBox.Enabled = false;
            StatusTextBox.Enabled = false;
            NoPatientTextBox.Enabled = false;
            NoRank3TextBox.Enabled = false;
            CStatusTextBox.Enabled = false;
            NoCPatientTextBox.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(menu);
            this.Parent.Controls.Remove(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
