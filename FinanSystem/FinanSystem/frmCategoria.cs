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
        // NOVO ===========
        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;
        // ======================

        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
        }

        private void preencheCampos()
        {
            txtNome.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            txtDesc.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[2].Value.ToString();

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[3].Value.ToString()) == 1)
                rbtnReceita.Checked = true;
            else
                rbtnDespesa.Checked = true;

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[4].Value.ToString()) == 1)
                cbAtiva.Checked = true;
            else
                cbAtiva.Checked = false;


        }
        // NOVO =========================
        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            // dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
        }
        // ================

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnNovo.Visible = true;
            btnAlterar.Visible = true;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            dgCategoria.ColumnCount = 5;
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[0].HeaderText = "ID";
            dgCategoria.Columns[0].DataPropertyName = "Id";
            dgCategoria.Columns[0].Visible = false;
            dgCategoria.Columns[1].Width = 200;
            dgCategoria.Columns[1].HeaderText = "NOME";
            dgCategoria.Columns[1].DataPropertyName = "Nome";
            dgCategoria.Columns[2].Width = 400;
            dgCategoria.Columns[2].HeaderText = "DESCRIÇÃO";
            dgCategoria.Columns[2].DataPropertyName = "Descricao";
            dgCategoria.Columns[3].Width = 50;
            dgCategoria.Columns[3].HeaderText = "TIPO";
            dgCategoria.Columns[3].DataPropertyName = "Tipo";
            dgCategoria.Columns[4].Width = 50;
            dgCategoria.Columns[4].HeaderText = "STATUS";
            dgCategoria.Columns[4].DataPropertyName = "Status";

            dgCategoria.AllowUserToAddRows = false;
            dgCategoria.AllowUserToDeleteRows = false;
            dgCategoria.MultiSelect = false;
            dgCategoria.ReadOnly = true;
            dgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridCategoria();

        }
        private void salvarRegistro(object sender, EventArgs e)
        {
            if (Insercao)
            {
                var nome = txtNome.Text.Trim();
                var descr = txtDesc.Text.Trim();
                var tipo = rbtnReceita.Checked ? 1 : 2;
                var status = cbAtiva.Checked ? 1 : 0;
                categoria.AddToList(3, nome, descr, tipo, status);
            }
            if (Edicao)
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
                if (ct != null)
                {
                    ct.Descricao = txtDesc.Text.Trim();
                    ct.Tipo = rbtnReceita.Checked ? 1 : 2;

                    ct.Status = cbAtiva.Checked ? 1 : 0;
                }
            }

            carregaGridCategoria();

            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnNovo.Focus();
            txtNome.Enabled = true;
            groupBox1.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true;

            Insercao = false;
            Edicao = false;
        }

        private void excluiRegistro(object sender, EventArgs e)
        {
            if (dgCategoria.RowCount > 0) { 
            DialogResult resp;
            resp = MessageBox.Show("Confirma exclusão?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                dgCategoria.Rows.RemoveAt(dgCategoria.CurrentRow.Index);
                limparCampos();
                resp = MessageBox.Show("Registro excluído com sucesso!", "Aviso do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }
        else
                MessageBox.Show("Não há um registro selecionado.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void novoRegistro(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
            txtNome.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            groupBox1.Enabled = true;
            Insercao = true;
            Edicao = true;

            dgCategoria.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDesc.Clear();
            rbtnDespesa.Checked = false;
            rbtnReceita.Checked = false;
            cbAtiva.Checked = false;
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fecharForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Termine (salve ou cancele) a operação atual para fechar o formulário!", "Aviso do sistema!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void alterarRegistro(object sender, EventArgs e)
        {
            
            if (dgCategoria.RowCount != 0)
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Visible = false;
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                groupBox1.Enabled = true;
                txtNome.Enabled = false;
                txtDesc.Focus();
                dgCategoria.Enabled = true;
                Insercao = false;
                Edicao = true;
                preencheCampos();
            }
            else
                MessageBox.Show("Não há um registro selecionado.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgCategoria.Enabled = true;
            Insercao = false;
            Edicao = false;
            if (dgCategoria.RowCount < 0)
            preencheCampos();
        }

        private void dgCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.RowCount > 0)
            {
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDesc.Text = dgCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    rbtnReceita.Checked = true;
                else
                    rbtnDespesa.Checked = true;

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                    cbAtiva.Checked = true; 
                else
                    cbAtiva.Checked = false;
            }
        }
    }
}
