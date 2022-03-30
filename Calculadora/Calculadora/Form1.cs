using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnZero_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ciao, sono il ZERO");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        
       
    }
}
