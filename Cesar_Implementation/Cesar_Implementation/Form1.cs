using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar_Implementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Alphapets = "ABCDEFGHILKLMNOPQRSTUVWXYZ";
        private void btnTashfer_Click(object sender, EventArgs e)
        {
            txtAfterTashfer.Clear();
            txtAfterFkTashfer.Clear();
            if (txtPlanText.Text == "" || txtTashferKey.Text == "")
            {
                MessageBox.Show("Complete the fields a thousand");
            }
            else
            {
                string LetterToUpper = txtPlanText.Text.ToUpper();
                char[] Letter = LetterToUpper.ToCharArray();
                for (int i = 0; i < Letter.Length; i++)
                {
                    if (Alphapets.Contains(Letter[i]))
                    {
                        int letterNumber = Alphapets.IndexOf(Letter[i]);
                       txtAfterTashfer.Text +=  Alphapets[((letterNumber + Convert.ToInt32(txtTashferKey.Text))%26) ];  
                    }
                    else
                    {
                        txtAfterTashfer.Text += Letter[i];
                    }
                }
                btnFkTashfer.Enabled = true;
            }
            txtPlanText.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            a.Show();
            this.Hide();
        }

        private void btnFkTashfer_Click(object sender, EventArgs e)
        {
            if (txtAfterTashfer.Text == "" || txtTashferKey.Text == "")
            {
                MessageBox.Show("Complete the fields a thousand");
            }
            else
            {
                string LetterToUpper = txtPlanText.Text.ToUpper();
                char[] Letter = LetterToUpper.ToCharArray();
                for (int i = 0; i < Letter.Length; i++)
                {
                    if (Alphapets.Contains(Letter[i]))
                    {
                        int letterNumber = Alphapets.IndexOf(Letter[i]);
                        txtAfterFkTashfer.Text += Alphapets[((letterNumber - Convert.ToInt32(txtTashferKey.Text))+26) % 26];
                    }
                    else
                    {
                        txtAfterFkTashfer.Text += Letter[i];
                    }
                }
                txtAfterTashfer.Text = "";
                txtTashferKey.Text = "";
            }
        }
    }
}
