using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtEvento.Text != string.Empty)
                    mskData.Focus();
            }
        }

        private void mskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Convert.ToDateTime(mskData.Text);
                    listBox1.Items.Add(txtEvento.Text);
                    listBox2.Items.Add(mskData.Text);
                    txtEvento.Clear();
                    mskData.Clear();
                } catch (Exception ex)
                {
                    MessageBox.Show("Data inválida.");
                    mskData.Focus();
                }
            }
        }

        private void Bolsonaro_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
                txtBonoro.Text = (int.Parse(txtBonoro.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 1)
                txtTebet.Text = (int.Parse(txtTebet.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 2)
                txtLula.Text = (int.Parse(txtLula.Text) + 1).ToString();
            else
                MessageBox.Show("Selecione um candidato!");

            listBox3.ClearSelected();
        }

        private void txtEvento_Leave(object sender, EventArgs e)
        {
            if (txtEvento.Text.Equals(""))
                txtEvento.Focus();
        }

        private void mskData_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBonoro.Text = "0";
            txtTebet.Text = "0";
            txtLula.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            } catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }
    }
}
