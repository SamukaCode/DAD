namespace Av3
{
    partial class frmMovimento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.txtSaldo);
            this.gbox1.Controls.Add(this.txtLimite);
            this.gbox1.Controls.Add(this.label3);
            this.gbox1.Controls.Add(this.label2);
            this.gbox1.Controls.Add(this.txtConta);
            this.gbox1.Controls.Add(this.rdEspecial);
            this.gbox1.Controls.Add(this.rdComum);
            this.gbox1.Controls.Add(this.label1);
            this.gbox1.Location = new System.Drawing.Point(12, 12);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(645, 110);
            this.gbox1.TabIndex = 0;
            this.gbox1.TabStop = false;
            this.gbox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldo.Location = new System.Drawing.Point(491, 52);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(148, 34);
            this.txtSaldo.TabIndex = 7;
            // 
            // txtLimite
            // 
            this.txtLimite.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLimite.Location = new System.Drawing.Point(316, 52);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(148, 34);
            this.txtLimite.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(491, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limite";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConta.Location = new System.Drawing.Point(6, 52);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(149, 34);
            this.txtConta.TabIndex = 3;
            this.txtConta.Leave += new System.EventHandler(this.btnConta_Leave);
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdEspecial.Location = new System.Drawing.Point(172, 59);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(128, 25);
            this.rdEspecial.TabIndex = 2;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdComum.Location = new System.Drawing.Point(172, 22);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(129, 25);
            this.rdComum.TabIndex = 1;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDepositar.Location = new System.Drawing.Point(12, 128);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(185, 66);
            this.btnDepositar.TabIndex = 1;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.btnLancar);
            this.gbox2.Controls.Add(this.txtValor);
            this.gbox2.Controls.Add(this.label5);
            this.gbox2.Controls.Add(this.dtMovimento);
            this.gbox2.Controls.Add(this.label4);
            this.gbox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbox2.Location = new System.Drawing.Point(12, 215);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(645, 99);
            this.gbox2.TabIndex = 2;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "MOVIMENTO:";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLancar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLancar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLancar.Location = new System.Drawing.Point(491, 44);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(134, 41);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(229, 51);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(148, 34);
            this.txtValor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(229, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(6, 52);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtMovimento.Size = new System.Drawing.Size(135, 33);
            this.dtMovimento.TabIndex = 9;
            this.dtMovimento.Value = new System.DateTime(2022, 6, 21, 23, 40, 22, 0);
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSacar.Location = new System.Drawing.Point(214, 128);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(185, 66);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(481, 128);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 66);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "S A I R";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.gbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Conta";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbox1;
        private Label label1;
        private TextBox txtSaldo;
        private TextBox txtLimite;
        private Label label3;
        private Label label2;
        private TextBox txtConta;
        private RadioButton rdEspecial;
        private RadioButton rdComum;
        private Button btnDepositar;
        private GroupBox gbox2;
        private Button btnSacar;
        private Button btnSair;
        private DateTimePicker dtMovimento;
        private Label label4;
        private Button btnLancar;
        private TextBox txtValor;
        private Label label5;
    }
}