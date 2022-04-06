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
    public partial class frmCalculadora : Form
    {
        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado;
        private Boolean PressionouIgual;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            numero1 = 0;
            numero2 = 0;
            operacao = String.Empty;
            resultado = 0;
            PressionouIgual = false;
            txtDisplay.Clear();
        }

        private void adicionarOperacao(string caractere)
        {
            if(!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                txtDisplay.Clear();
                operacao = caractere;
            }
        }

        void adicionarDigito(String digito)
        {
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = digito;
            }
            else
            {
                txtDisplay.Text += digito;
            }
        }

        private void Calcular()
        {
            switch(operacao)
            {
                case "/":
                    if(numero2 ==0)
                    {
                        MessageBox.Show("Impossível divisão por zero!",
                            "Aviso do sistema", MessageBoxButtons.OK);
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;

                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "y":
                    resultado = System.Math.Pow(numero1, numero2);
                    break;
            }
            txtDisplay.Text = resultado.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            adicionarDigito("5");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adicionarDigito("9");
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            LimparCampos();
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

        private void btnUm_Click(object sender, EventArgs e)
        {
            adicionarDigito("1");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            adicionarDigito("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            adicionarDigito("4");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            adicionarDigito("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            adicionarDigito("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            adicionarDigito("8");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            adicionarDigito("2");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            adicionarOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                Calcular();
                PressionouIgual = true;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            adicionarOperacao("+");
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            adicionarOperacao("-");
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            adicionarOperacao("*");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if(PressionouIgual)
            {
                LimparCampos();
            }
            if (txtDisplay.Text.Trim().Equals(string.Empty))
            {
                txtDisplay.Text += "0,";
            }
            if (txtDisplay.Text.Trim().Contains(",")) return;
            txtDisplay.Text += ",";
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Contains("-"))
                txtDisplay.Text = "-" + txtDisplay.Text;
            else
                txtDisplay.Text = txtDisplay.Text.Replace("-", "");
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text));
        }

        private void btnElevay_Click(object sender, EventArgs e)
        {
            adicionarOperacao("y");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(txtDisplay.Text)));
        }

        private void btnFraciona_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Convert.ToString(1 / (Convert.ToDouble(txtDisplay.Text)));
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }
    }
}
