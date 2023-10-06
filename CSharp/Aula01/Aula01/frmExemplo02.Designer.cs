namespace Aula01
{
    partial class frmExemplo02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informe seu sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seu nome completo é:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(359, 35);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(387, 42);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(359, 35);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(12, 113);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.ReadOnly = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(734, 35);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(585, 154);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(161, 38);
            this.btoSair.TabIndex = 5;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(418, 154);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(161, 38);
            this.btoLimpar.TabIndex = 4;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(251, 154);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(161, 38);
            this.btoOK.TabIndex = 3;
            this.btoOK.Text = "O&K";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // frmExemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 199);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmExemplo02";
            this.Text = "frmExemplo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtNomeCompleto;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoOK;
    }
}