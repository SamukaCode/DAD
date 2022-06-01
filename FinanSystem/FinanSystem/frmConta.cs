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
    public partial class frmConta : Form
    {
        private Conta conta = new Conta();
        private List<Conta> lstConta = new List<Conta>();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsConta;
        private BindingSource bsCategoria;

        public frmConta()
        {
            InitializeComponent();
            lstConta = conta.GeraContas();
            lstConta = (new Conta()).GeraContas();
        }
        private void preencheCampos()
        {
            txtNome.Text = dgConta.Rows[dgConta.CurrentRow.Index].Cells[1].Value.ToString();
            txtDesc.Text = dgConta.Rows[dgConta.CurrentRow.Index].Cells[2].Value.ToString();

            if (Convert.ToInt16(dgConta.Rows[dgConta.CurrentRow.Index].Cells[3].Value.ToString()) == 1)
                cbStatus.Checked = true;
            else
                cbStatus.Checked = true;
        }

        private void carregaComboCategoria(int id=0)
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            cboCategoria.DataSource = bsCategoria;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.SelectedItem = "id";
            if(id>0)
            {
                foreach(var c in lstCategoria)
                {
                    if (c.Id == id)
                    {
                        int index = cboCategoria.FindString(c.Nome);
                        cboCategoria.SelectedIndex = index;
                    }
                }
            }

            cboCategoria.Refresh();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            carregaComboCategoria();
            dgConta.AllowUserToAddRows = false;
            dgConta.AllowUserToDeleteRows = false;
            dgConta.MultiSelect = false;
            dgConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgConta.ColumnCount = 4;
            dgConta.AutoGenerateColumns = false;
            dgConta.Columns[0].Width = 50;
            dgConta.Columns[0].HeaderText = "ID";
            dgConta.Columns[0].DataPropertyName = "Id";
            dgConta.Columns[0].Visible = false;
            dgConta.Columns[1].Width = 250;
            dgConta.Columns[1].HeaderText = "NOME";
            dgConta.Columns[1].DataPropertyName = "Nome";
            dgConta.Columns[2].Width = 400;
            dgConta.Columns[2].HeaderText = "DESCRIÇÃO";
            dgConta.Columns[2].DataPropertyName = "Descricao";
            dgConta.Columns[3].Width = 50;
            dgConta.Columns[3].Visible = false;
            dgConta.Columns[3].HeaderText = "STATUS";
            dgConta.Columns[3].DataPropertyName = "Status";

            dgConta.AllowUserToAddRows = false;
            dgConta.AllowUserToDeleteRows = false;
            dgConta.MultiSelect = false;
            dgConta.ReadOnly = true;
            dgConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridConta();
        }

        private void carregaGridConta()
        {
            bsConta = new BindingSource();
            bsConta.DataSource = lstConta;
            // dgConta.Rows.Clear();
            dgConta.DataSource = bsConta;
            dgConta.Refresh();
        }

        private void dgConta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgConta.RowCount > 0)
            {
                int _id = Convert.ToInt32(dgConta.Rows[e.RowIndex].Cells[0].Value);
                carregaComboCategoria(_id);

                txtNome.Text = dgConta.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDesc.Text = dgConta.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgConta.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    cbStatus.Checked = true;
                else
                    cbStatus.Checked = false;
            }
        }
    }
}
