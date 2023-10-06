namespace Aula03
{
    partial class frmAula03
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btoDesconto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btoFim = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.txtValorUnitario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Produto A",
            "Produto B",
            "Produto C"});
            this.cboProduto.Location = new System.Drawing.Point(12, 42);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(333, 38);
            this.cboProduto.TabIndex = 1;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // btoDesconto
            // 
            this.btoDesconto.Location = new System.Drawing.Point(577, 113);
            this.btoDesconto.Name = "btoDesconto";
            this.btoDesconto.Size = new System.Drawing.Size(220, 42);
            this.btoDesconto.TabIndex = 3;
            this.btoDesconto.Text = "Com Desconto 20%";
            this.btoDesconto.UseVisualStyleBackColor = true;
            this.btoDesconto.Click += new System.EventHandler(this.btoDesconto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(12, 113);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(559, 138);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btoFim
            // 
            this.btoFim.Location = new System.Drawing.Point(577, 161);
            this.btoFim.Name = "btoFim";
            this.btoFim.Size = new System.Drawing.Size(220, 42);
            this.btoFim.TabIndex = 3;
            this.btoFim.Text = "Finalizar Compra";
            this.btoFim.UseVisualStyleBackColor = true;
            this.btoFim.Click += new System.EventHandler(this.btoFim_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(577, 209);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(220, 42);
            this.btoSair.TabIndex = 3;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(577, 42);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(220, 36);
            this.txtQtde.TabIndex = 4;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.FormattingEnabled = true;
            this.txtValorUnitario.Items.AddRange(new object[] {
            "2,50",
            "8,50",
            "6,35"});
            this.txtValorUnitario.Location = new System.Drawing.Point(351, 42);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(220, 53);
            this.txtValorUnitario.TabIndex = 5;
            // 
            // frmAula03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 271);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoFim);
            this.Controls.Add(this.btoDesconto);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAula03";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboProduto;
        private Label label2;
        private Label label3;
        private Button btoDesconto;
        private Label label4;
        private Label lblResult;
        private Button btoFim;
        private Button btoSair;
        private NumericUpDown txtQtde;
        private ComboBox txtValorUnitario;
    }
}