
namespace FinanSystem
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAtiva = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnDespesa = new System.Windows.Forms.RadioButton();
            this.rbtnReceita = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAtiva);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.rbtnDespesa);
            this.groupBox1.Controls.Add(this.rbtnReceita);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbAtiva
            // 
            this.cbAtiva.AutoSize = true;
            this.cbAtiva.Location = new System.Drawing.Point(84, 107);
            this.cbAtiva.Name = "cbAtiva";
            this.cbAtiva.Size = new System.Drawing.Size(53, 19);
            this.cbAtiva.TabIndex = 8;
            this.cbAtiva.Text = "Ativa";
            this.cbAtiva.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // rbtnDespesa
            // 
            this.rbtnDespesa.AutoSize = true;
            this.rbtnDespesa.Location = new System.Drawing.Point(153, 78);
            this.rbtnDespesa.Name = "rbtnDespesa";
            this.rbtnDespesa.Size = new System.Drawing.Size(68, 19);
            this.rbtnDespesa.TabIndex = 6;
            this.rbtnDespesa.TabStop = true;
            this.rbtnDespesa.Text = "Despesa";
            this.rbtnDespesa.UseVisualStyleBackColor = true;
            // 
            // rbtnReceita
            // 
            this.rbtnReceita.AutoSize = true;
            this.rbtnReceita.Location = new System.Drawing.Point(84, 78);
            this.rbtnReceita.Name = "rbtnReceita";
            this.rbtnReceita.Size = new System.Drawing.Size(63, 19);
            this.rbtnReceita.TabIndex = 5;
            this.rbtnReceita.TabStop = true;
            this.rbtnReceita.Text = "Receita";
            this.rbtnReceita.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 52);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 15);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(84, 49);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(527, 23);
            this.txtDesc.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 20);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 377);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.novoRegistro);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(96, 377);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.alterarRegistro);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(177, 376);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.excluiRegistro);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(258, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.salvarRegistro);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(567, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.cancelaOperacao);
            // 
            // dgCategoria
            // 
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Location = new System.Drawing.Point(12, 157);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.RowTemplate.Height = 25;
            this.dgCategoria.Size = new System.Drawing.Size(629, 213);
            this.dgCategoria.TabIndex = 6;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoria";
            this.ShowIcon = false;
            this.Text = "frmCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fecharForm);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAtiva;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnDespesa;
        private System.Windows.Forms.RadioButton rbtnReceita;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgCategoria;
    }
}