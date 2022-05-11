using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanSystem
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustivel";
            txtDesc.Text = "Consumo de combustível";
            rbtnDespesa.Checked = true;
            cbAtiva.Checked = true;
            groupBox1.Enabled = false;
            btnNovo.Visible = true;
            btnNovo.Enabled = true;
            btnAlterar.Visible = true;
            btnAlterar.Enabled = true;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void salvarRegistro(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnNovo.Focus();
            groupBox1.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            Insercao = false;
            Edicao = false;
        }

        private void excluiRegistro(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Confirma exclusão?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                limparCampos();
                resp = MessageBox.Show("Registro excluído com sucesso!", "Aviso do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }

        private void novoRegistro(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            groupBox1.Enabled = true;
            Insercao = true;
            Edicao = true;
            rbtnDespesa.Checked = false;
            rbtnReceita.Checked = false;
            cbAtiva.Checked = true;
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDesc.Clear();
            rbtnDespesa.Checked = false;
            rbtnReceita.Checked = false;
            cbAtiva.Checked = false;
        }

        private void fecharForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Fique aqui!", "Aviso do sistema!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void alterarRegistro(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Visible = false;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            groupBox1.Enabled = true;
            txtNome.Focus();
            Insercao = false;
            Edicao = true;
        }

        private void cancelaOperacao(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            groupBox1.Enabled = false;
            btnNovo.Focus();
            Insercao = true;
            Edicao = false;
        }

    }
}
