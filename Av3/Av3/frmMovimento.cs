namespace Av3
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        private bool deposito = false;
        private bool saque = false;

        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();
        }

    private void frmMovimento_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            gbox1.Enabled = false;
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
            deposito = true;
            saque = false;
        }

        private void btnConta_Leave(object sender, EventArgs e)
        {
            bool found=false;
            foreach (contaBancaria conta in _listConta)
            {
                if(conta.CodigoConta.Equals(txtConta.Text))
                {
                    found = true;
                    txtLimite.Text = Convert.ToString(conta.Limite);
                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                    if (conta.Tipo == 0)
                    {
                        rdComum.Checked = true;
                        rdEspecial.Checked = false;
                    } else
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
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            gbox1.Enabled = false;
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
            saque = true;
            deposito = false;
        }

        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!","Aviso do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                dtMovimento.Focus();
            }

        }
    }
}