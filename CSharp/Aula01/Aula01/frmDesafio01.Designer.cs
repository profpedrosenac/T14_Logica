namespace Aula01
{
    partial class frmDesafio01
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btoSoma = new System.Windows.Forms.Button();
            this.btoSub = new System.Windows.Forms.Button();
            this.btoDiv = new System.Windows.Forms.Button();
            this.btoMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 12);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 35);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(118, 12);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 35);
            this.txtN2.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Yellow;
            this.lblResult.Location = new System.Drawing.Point(12, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(206, 39);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btoSoma
            // 
            this.btoSoma.Location = new System.Drawing.Point(224, 12);
            this.btoSoma.Name = "btoSoma";
            this.btoSoma.Size = new System.Drawing.Size(71, 35);
            this.btoSoma.TabIndex = 2;
            this.btoSoma.Text = "+";
            this.btoSoma.UseVisualStyleBackColor = true;
            this.btoSoma.Click += new System.EventHandler(this.btoSoma_Click);
            // 
            // btoSub
            // 
            this.btoSub.Location = new System.Drawing.Point(301, 13);
            this.btoSub.Name = "btoSub";
            this.btoSub.Size = new System.Drawing.Size(71, 35);
            this.btoSub.TabIndex = 3;
            this.btoSub.Text = "-";
            this.btoSub.UseVisualStyleBackColor = true;
            // 
            // btoDiv
            // 
            this.btoDiv.Location = new System.Drawing.Point(301, 54);
            this.btoDiv.Name = "btoDiv";
            this.btoDiv.Size = new System.Drawing.Size(71, 35);
            this.btoDiv.TabIndex = 5;
            this.btoDiv.Text = "/";
            this.btoDiv.UseVisualStyleBackColor = true;
            // 
            // btoMult
            // 
            this.btoMult.Location = new System.Drawing.Point(224, 54);
            this.btoMult.Name = "btoMult";
            this.btoMult.Size = new System.Drawing.Size(71, 35);
            this.btoMult.TabIndex = 4;
            this.btoMult.Text = "*";
            this.btoMult.UseVisualStyleBackColor = true;
            // 
            // frmDesafio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 100);
            this.Controls.Add(this.btoMult);
            this.Controls.Add(this.btoDiv);
            this.Controls.Add(this.btoSub);
            this.Controls.Add(this.btoSoma);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDesafio01";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblResult;
        private Button btoSoma;
        private Button btoSub;
        private Button btoDiv;
        private Button btoMult;
    }
}