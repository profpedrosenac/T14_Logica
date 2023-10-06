namespace Aula02
{
    partial class frmMediaEscolar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btoOK = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "n1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "n2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "n3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "n4";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(12, 42);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(71, 36);
            this.txtn1.TabIndex = 0;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(89, 42);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(71, 36);
            this.txtn2.TabIndex = 1;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(166, 42);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(71, 36);
            this.txtn3.TabIndex = 2;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(243, 42);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(71, 36);
            this.txtn4.TabIndex = 3;
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(12, 84);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.ReadOnly = true;
            this.txtmedia.Size = new System.Drawing.Size(302, 36);
            this.txtmedia.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 126);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(302, 36);
            this.txtStatus.TabIndex = 5;
            // 
            // btoOK
            // 
            this.btoOK.Location = new System.Drawing.Point(320, 42);
            this.btoOK.Name = "btoOK";
            this.btoOK.Size = new System.Drawing.Size(123, 36);
            this.btoOK.TabIndex = 6;
            this.btoOK.Text = "OK";
            this.btoOK.UseVisualStyleBackColor = true;
            this.btoOK.Click += new System.EventHandler(this.btoOK_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(320, 84);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(123, 36);
            this.btoLimpar.TabIndex = 7;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(320, 126);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(123, 36);
            this.btoSair.TabIndex = 8;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // frmMediaEscolar
            // 
            this.AcceptButton = this.btoOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btoSair;
            this.ClientSize = new System.Drawing.Size(455, 177);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoOK);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMediaEscolar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtn1;
        private TextBox txtn2;
        private TextBox txtn3;
        private TextBox txtn4;
        private TextBox txtmedia;
        private TextBox txtStatus;
        private Button btoOK;
        private Button btoLimpar;
        private Button btoSair;
    }
}