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
            resp = MessageBox.Show("Tem certeza que deseja apagar o registro?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                limparCampos();
                resp = MessageBox.Show("Registro apagado com sucesso!", "Alerta!");
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
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDesc.Clear();
            rbtnDespesa.Checked = false;
            rbtnReceita.Checked = false;
            cbAtiva.Checked = false;
        }

        private void cbAtiva_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
