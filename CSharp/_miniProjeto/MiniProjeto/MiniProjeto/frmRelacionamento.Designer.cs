namespace MiniProjeto
{
    partial class frmRelacionamento
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
            this.cboIDProduto = new System.Windows.Forms.ComboBox();
            this.cboNomeProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboIDProduto
            // 
            this.cboIDProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboIDProduto.Enabled = false;
            this.cboIDProduto.FormattingEnabled = true;
            this.cboIDProduto.Location = new System.Drawing.Point(12, 116);
            this.cboIDProduto.Name = "cboIDProduto";
            this.cboIDProduto.Size = new System.Drawing.Size(709, 38);
            this.cboIDProduto.TabIndex = 1;
            // 
            // cboNomeProduto
            // 
            this.cboNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeProduto.FormattingEnabled = true;
            this.cboNomeProduto.Location = new System.Drawing.Point(12, 42);
            this.cboNomeProduto.Name = "cboNomeProduto";
            this.cboNomeProduto.Size = new System.Drawing.Size(709, 38);
            this.cboNomeProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Produto";
            // 
            // frmRelacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNomeProduto);
            this.Controls.Add(this.cboIDProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRelacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelacionamento";
            this.Load += new System.EventHandler(this.frmRelacionamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboIDProduto;
        private ComboBox cboNomeProduto;
        private Label label1;
        private Label label2;
    }
}