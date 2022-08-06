namespace Classes_Clientes
{
    partial class Form1
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbClasse = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lbContato = new System.Windows.Forms.Label();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.lbDtNasc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbLimite = new System.Windows.Forms.Label();
            this.txbLimiteCredito = new System.Windows.Forms.TextBox();
            this.lbNumCartao = new System.Windows.Forms.Label();
            this.txbNumCartao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblLimCredito = new System.Windows.Forms.Label();
            this.lblNumCartao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(156, 130);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(325, 29);
            this.txbNome.TabIndex = 0;
            // 
            // lbClasse
            // 
            this.lbClasse.AutoSize = true;
            this.lbClasse.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClasse.Location = new System.Drawing.Point(49, 37);
            this.lbClasse.Name = "lbClasse";
            this.lbClasse.Size = new System.Drawing.Size(161, 27);
            this.lbClasse.TabIndex = 1;
            this.lbClasse.Text = "Classe Cliente";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(60, 133);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 21);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEndereco.Location = new System.Drawing.Point(60, 183);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(91, 21);
            this.lbEndereco.TabIndex = 4;
            this.lbEndereco.Text = "Endereço:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEndereco.Location = new System.Drawing.Point(156, 180);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(325, 29);
            this.txbEndereco.TabIndex = 3;
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContato.Location = new System.Drawing.Point(60, 232);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(79, 21);
            this.lbContato.TabIndex = 6;
            this.lbContato.Text = "Contato:";
            // 
            // txbContato
            // 
            this.txbContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContato.Location = new System.Drawing.Point(156, 229);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(325, 29);
            this.txbContato.TabIndex = 5;
            // 
            // lbDtNasc
            // 
            this.lbDtNasc.AutoSize = true;
            this.lbDtNasc.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDtNasc.Location = new System.Drawing.Point(60, 287);
            this.lbDtNasc.Name = "lbDtNasc";
            this.lbDtNasc.Size = new System.Drawing.Size(155, 21);
            this.lbDtNasc.TabIndex = 7;
            this.lbDtNasc.Text = "Data Nascimento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lbLimite
            // 
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLimite.Location = new System.Drawing.Point(60, 334);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(156, 21);
            this.lbLimite.TabIndex = 10;
            this.lbLimite.Text = "Limite de Crédito:";
            // 
            // txbLimiteCredito
            // 
            this.txbLimiteCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLimiteCredito.Location = new System.Drawing.Point(248, 331);
            this.txbLimiteCredito.Name = "txbLimiteCredito";
            this.txbLimiteCredito.Size = new System.Drawing.Size(233, 29);
            this.txbLimiteCredito.TabIndex = 9;
            // 
            // lbNumCartao
            // 
            this.lbNumCartao.AutoSize = true;
            this.lbNumCartao.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumCartao.Location = new System.Drawing.Point(60, 384);
            this.lbNumCartao.Name = "lbNumCartao";
            this.lbNumCartao.Size = new System.Drawing.Size(120, 21);
            this.lbNumCartao.TabIndex = 12;
            this.lbNumCartao.Text = "Nº do Cartão:";
            // 
            // txbNumCartao
            // 
            this.txbNumCartao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumCartao.Location = new System.Drawing.Point(248, 381);
            this.txbNumCartao.Name = "txbNumCartao";
            this.txbNumCartao.Size = new System.Drawing.Size(233, 29);
            this.txbNumCartao.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(156, 429);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(163, 48);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(60, 501);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "label7";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(60, 524);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(38, 15);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "label8";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(60, 550);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(38, 15);
            this.lblContato.TabIndex = 16;
            this.lblContato.Text = "label9";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(329, 501);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(44, 15);
            this.lblDtNasc.TabIndex = 17;
            this.lblDtNasc.Text = "label10";
            // 
            // lblLimCredito
            // 
            this.lblLimCredito.AutoSize = true;
            this.lblLimCredito.Location = new System.Drawing.Point(329, 524);
            this.lblLimCredito.Name = "lblLimCredito";
            this.lblLimCredito.Size = new System.Drawing.Size(44, 15);
            this.lblLimCredito.TabIndex = 18;
            this.lblLimCredito.Text = "label11";
            // 
            // lblNumCartao
            // 
            this.lblNumCartao.AutoSize = true;
            this.lblNumCartao.Location = new System.Drawing.Point(329, 550);
            this.lblNumCartao.Name = "lblNumCartao";
            this.lblNumCartao.Size = new System.Drawing.Size(44, 15);
            this.lblNumCartao.TabIndex = 19;
            this.lblNumCartao.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(553, 603);
            this.Controls.Add(this.lblNumCartao);
            this.Controls.Add(this.lblLimCredito);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbNumCartao);
            this.Controls.Add(this.txbNumCartao);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.txbLimiteCredito);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDtNasc);
            this.Controls.Add(this.lbContato);
            this.Controls.Add(this.txbContato);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbClasse);
            this.Controls.Add(this.txbNome);
            this.Name = "Form1";
            this.Text = "Classe Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNome;
        private Label lbClasse;
        private Label lbNome;
        private Label lbEndereco;
        private TextBox txbEndereco;
        private Label lbContato;
        private TextBox txbContato;
        private Label lbDtNasc;
        private DateTimePicker dateTimePicker1;
        private Label lbLimite;
        private TextBox txbLimiteCredito;
        private Label lbNumCartao;
        private TextBox txbNumCartao;
        private Button btnCadastrar;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblContato;
        private Label lblDtNasc;
        private Label lblLimCredito;
        private Label lblNumCartao;
    }
}