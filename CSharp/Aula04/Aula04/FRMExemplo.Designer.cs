namespace Aula04
{
    partial class FRMExemplo
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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.list01 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(12, 12);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(526, 38);
            this.cboProduto.TabIndex = 4;
            // 
            // list01
            // 
            this.list01.FormattingEnabled = true;
            this.list01.ItemHeight = 30;
            this.list01.Items.AddRange(new object[] {
            "Produto - Qtde - Valor Unitario - Total"});
            this.list01.Location = new System.Drawing.Point(12, 56);
            this.list01.Name = "list01";
            this.list01.Size = new System.Drawing.Size(526, 394);
            this.list01.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.list01);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FRMExemplo";
            this.Text = "FRMExemplo";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboProduto;
        private ListBox list01;
        private Button button1;
    }
}