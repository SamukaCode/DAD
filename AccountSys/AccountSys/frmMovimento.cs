using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSys
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        private bool saque = false;
        private bool deposito = false;

        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            // Conteúdo inserido diretamente no btnDepositar e btnSacar.
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (contaBancaria conta in _listConta)
            {
                if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                {
                    found = true;
                    txtLimite.Text = Convert.ToString(conta.Limite);
                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                    if (conta.Tipo == 0)
                    {
                        rdComum.Checked = true;
                        rdEspecial.Checked = false;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                        rdComum.Checked = false;
                    }
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Nenhuma conta encontrada, tente novamente.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConta.Focus();
            }
            else
            {
                txtConta.Enabled = false;
                btnDepositar.Enabled = false;
                btnSacar.Enabled = false;
                btnSair.Enabled = false;
                this.Size = new Size(685, 365);
                deposito = true;
                saque = false;
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (contaBancaria conta in _listConta)
            {
                if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                {
                    found = true;
                    txtLimite.Text = Convert.ToString(conta.Limite);
                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                    if (conta.Tipo == 0)
                    {
                        rdComum.Checked = true;
                        rdEspecial.Checked = false;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                        rdComum.Checked = false;
                    }
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Nenhuma conta encontrada, tente novamente.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConta.Focus();
            }
            else
            {
                txtConta.Enabled = false;
                btnDepositar.Enabled = false;
                btnSacar.Enabled = false;
                btnSair.Enabled = false;
                this.Size = new Size(685, 365);
                saque = true;
                deposito = false;
            }
        }

        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtMovimento.Focus();
            }

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtValor.Text) < 0)
                {
                    MessageBox.Show("Não é permitido um valor negativo. Tente novamente", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Focus();
                }
            } catch (System.FormatException)
            {
                MessageBox.Show("Letras não são permitidas, digite um número.","Aviso do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("O campo VALOR está vazio. Digite algo.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
            else
            {

                foreach (contaBancaria conta in _listConta)
                {
                    if (txtConta.Text.Equals(conta.CodigoConta))
                    {
                        if (conta.Tipo == 0)
                        {
                            if (saque)
                            {
                                if ((conta.Saldo - Convert.ToDouble(txtValor.Text)) < 0)
                                {
                                    MessageBox.Show("Erro, o saldo não pode ficar negativo!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    conta.Saldo -= Convert.ToDouble(txtValor.Text);
                                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                                    MessageBox.Show("Operação concluída com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            if (deposito)
                            {
                                conta.Saldo += Convert.ToDouble(txtValor.Text);
                                txtSaldo.Text = Convert.ToString(conta.Saldo);
                                MessageBox.Show("Operação concluída com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        if (conta.Tipo == 1)
                        {
                            if (saque)
                            {
                                double sa = Convert.ToDouble("-" + txtLimite.Text);
                                if ((conta.Saldo - Convert.ToDouble(txtValor.Text)) < sa)
                                {
                                    MessageBox.Show("Erro, o saldo não pode ficar abaixo do limite!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    conta.Saldo -= Convert.ToDouble(txtValor.Text);
                                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                                    MessageBox.Show("Operação concluída com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            if (deposito)
                            {
                                conta.Saldo += Convert.ToDouble(txtValor.Text);
                                txtSaldo.Text = Convert.ToString(conta.Saldo);
                                MessageBox.Show("Operação concluída com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                this.Size = new Size(685, 255);
                txtValor.Clear();
                txtConta.Enabled = true;
                btnDepositar.Enabled = true;
                btnSacar.Enabled = true;
                btnSair.Enabled = true;
                txtConta.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
