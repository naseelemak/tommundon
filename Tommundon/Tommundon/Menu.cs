using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tommundon
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patient);
            this.Parent.Controls.Remove(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Nurse nurse = new Nurse();
            nurse.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(nurse);
            this.Parent.Controls.Remove(this);
        }
    }
}
