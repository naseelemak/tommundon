using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tommundon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            this.Controls.Add(menu);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
