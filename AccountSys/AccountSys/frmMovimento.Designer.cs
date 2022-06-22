
namespace AccountSys
{
    partial class frmMovimento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.txtSaldo);
            this.gbox1.Controls.Add(this.label3);
            this.gbox1.Controls.Add(this.txtLimite);
            this.gbox1.Controls.Add(this.label2);
            this.gbox1.Controls.Add(this.rdEspecial);
            this.gbox1.Controls.Add(this.rdComum);
            this.gbox1.Controls.Add(this.txtConta);
            this.gbox1.Controls.Add(this.label1);
            this.gbox1.Location = new System.Drawing.Point(13, 13);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(644, 98);
            this.gbox1.TabIndex = 0;
            this.gbox1.TabStop = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(498, 53);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(126, 30);
            this.txtSaldo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // txtLimite
            // 
            this.txtLimite.Enabled = false;
            this.txtLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite.Location = new System.Drawing.Point(353, 53);
            this.txtLimite.MaxLength = 10;
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(126, 30);
            this.txtLimite.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limite";
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Enabled = false;
            this.rdEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEspecial.Location = new System.Drawing.Point(178, 55);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(154, 28);
            this.rdEspecial.TabIndex = 3;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Enabled = false;
            this.rdComum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdComum.Location = new System.Drawing.Point(178, 15);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(149, 28);
            this.rdComum.TabIndex = 2;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(11, 53);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(140, 30);
            this.txtConta.TabIndex = 1;
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Conta";
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.btnLancar);
            this.gbox2.Controls.Add(this.txtValor);
            this.gbox2.Controls.Add(this.dtMovimento);
            this.gbox2.Controls.Add(this.label5);
            this.gbox2.Controls.Add(this.label4);
            this.gbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox2.Location = new System.Drawing.Point(12, 216);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(644, 98);
            this.gbox2.TabIndex = 1;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "MOVIMENTO:";
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(480, 39);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(145, 45);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(212, 54);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(140, 30);
            this.txtValor.TabIndex = 8;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(7, 55);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(145, 29);
            this.dtMovimento.TabIndex = 10;
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(12, 126);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(183, 74);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(215, 126);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(183, 74);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(492, 126);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(164, 74);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "S A I R";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Conta";
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdEspecial;
        private System.Windows.Forms.RadioButton rdComum;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSair;
    }
}

