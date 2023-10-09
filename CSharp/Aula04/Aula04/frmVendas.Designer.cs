namespace Aula04
{
    partial class frmVendas
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
            this.listItemProdutos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.cboProdutoValor = new System.Windows.Forms.ComboBox();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.btoAdd = new System.Windows.Forms.Button();
            this.btoExcluid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // listItemProdutos
            // 
            this.listItemProdutos.FormattingEnabled = true;
            this.listItemProdutos.ItemHeight = 30;
            this.listItemProdutos.Items.AddRange(new object[] {
            "Produto - Qtde - Valor Unitario - Total"});
            this.listItemProdutos.Location = new System.Drawing.Point(544, 12);
            this.listItemProdutos.Name = "listItemProdutos";
            this.listItemProdutos.Size = new System.Drawing.Size(407, 394);
            this.listItemProdutos.TabIndex = 0;
            this.listItemProdutos.SelectedIndexChanged += new System.EventHandler(this.listItemProdutos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Bala",
            "Bolacha",
            "Biscoito",
            "Ovos",
            "Chocolate",
            "Miojo",
            "Paçoca",
            "Café",
            "Guaraná",
            "Arroz"});
            this.cboProduto.Location = new System.Drawing.Point(12, 45);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(526, 38);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // cboProdutoValor
            // 
            this.cboProdutoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboProdutoValor.Enabled = false;
            this.cboProdutoValor.FormattingEnabled = true;
            this.cboProdutoValor.Items.AddRange(new object[] {
            "R$ 9,33",
            "R$ 6,07",
            "R$ 7,58",
            "R$ 10,24",
            "R$ 3,09",
            "R$ 0,18",
            "R$ 8,25",
            "R$ 0,48",
            "R$ 3,97",
            "R$ 6,74"});
            this.cboProdutoValor.Location = new System.Drawing.Point(12, 128);
            this.cboProdutoValor.Name = "cboProdutoValor";
            this.cboProdutoValor.Size = new System.Drawing.Size(328, 38);
            this.cboProdutoValor.TabIndex = 1;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(346, 130);
            this.txtQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(192, 36);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 232);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(526, 174);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "R$ 0,00";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btoAdd
            // 
            this.btoAdd.Location = new System.Drawing.Point(463, 172);
            this.btoAdd.Name = "btoAdd";
            this.btoAdd.Size = new System.Drawing.Size(75, 57);
            this.btoAdd.TabIndex = 4;
            this.btoAdd.Text = "ADD";
            this.btoAdd.UseVisualStyleBackColor = true;
            this.btoAdd.Click += new System.EventHandler(this.btoAdd_Click);
            // 
            // btoExcluid
            // 
            this.btoExcluid.Location = new System.Drawing.Point(346, 172);
            this.btoExcluid.Name = "btoExcluid";
            this.btoExcluid.Size = new System.Drawing.Size(111, 57);
            this.btoExcluid.TabIndex = 3;
            this.btoExcluid.Text = "Excluir";
            this.btoExcluid.UseVisualStyleBackColor = true;
            this.btoExcluid.Click += new System.EventHandler(this.btoExcluid_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 418);
            this.Controls.Add(this.btoExcluid);
            this.Controls.Add(this.btoAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.cboProdutoValor);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listItemProdutos);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmVendas";
            this.Text = "Formulário de produtos";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listItemProdutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboProduto;
        private ComboBox cboProdutoValor;
        private NumericUpDown txtQtde;
        private Label lblResult;
        private Button btoAdd;
        private Button btoExcluid;
    }
}