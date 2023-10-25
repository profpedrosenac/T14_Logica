namespace MiniProjeto
{
    partial class frmUsuario
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
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.botPesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.botPesquisar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(532, 65);
            this.txtData.Mask = "##/##/####";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(264, 36);
            this.txtData.TabIndex = 2;
            // 
            // botPesquisar
            // 
            this.botPesquisar.Location = new System.Drawing.Point(276, 65);
            this.botPesquisar.Name = "botPesquisar";
            this.botPesquisar.Size = new System.Drawing.Size(75, 36);
            this.botPesquisar.TabIndex = 1;
            this.botPesquisar.Text = "...";
            this.botPesquisar.UseVisualStyleBackColor = true;
            this.botPesquisar.Click += new System.EventHandler(this.botPesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(264, 36);
            this.txtCodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(546, 135);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(250, 38);
            this.cboStatus.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(276, 137);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(264, 36);
            this.txtSenha.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 137);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(264, 36);
            this.txtLogin.TabIndex = 1;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 209);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(790, 130);
            this.txtObs.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(790, 36);
            this.txtNome.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Location = new System.Drawing.Point(12, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(167, 35);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(121, 41);
            this.btoCadastrar.TabIndex = 0;
            this.btoCadastrar.Text = "&Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(294, 35);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(121, 41);
            this.btoAlterar.TabIndex = 1;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(421, 35);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(121, 41);
            this.btoExcluir.TabIndex = 2;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(548, 35);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(121, 41);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(675, 35);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(121, 41);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridUsuario);
            this.groupBox4.Controls.Add(this.txtNomePesquisa);
            this.groupBox4.Location = new System.Drawing.Point(820, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 579);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Location = new System.Drawing.Point(6, 68);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            this.dataGridUsuario.RowTemplate.Height = 25;
            this.dataGridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuario.Size = new System.Drawing.Size(588, 505);
            this.dataGridUsuario.TabIndex = 1;
            this.dataGridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuario_CellClick);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(6, 26);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(588, 36);
            this.txtNomePesquisa.TabIndex = 0;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox txtData;
        private Button botPesquisar;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cboStatus;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label3;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private TextBox txtObs;
        private TextBox txtNome;
        private Button btoCadastrar;
        private Button btoAlterar;
        private Button btoExcluir;
        private Button btoLimpar;
        private Button btoSair;
        private GroupBox groupBox4;
        private DataGridView dataGridUsuario;
        private TextBox txtNomePesquisa;
    }
}