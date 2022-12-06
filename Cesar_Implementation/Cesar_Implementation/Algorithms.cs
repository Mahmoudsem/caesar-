using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cesar_Implementation
{
    public partial class Algorithms : Form
    {
        public Algorithms()
        {
            InitializeComponent();
        }

        private void cesarAlgorithmMenuStrip_Click(object sender, EventArgs e)
        {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cesarAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
       }

      
}
