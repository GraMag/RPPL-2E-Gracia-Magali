
namespace Formularios.FormDeRegistros
{
    partial class FormRegCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegCliente));
            this.lblEMail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.BackColor = System.Drawing.Color.Transparent;
            this.lblEMail.Location = new System.Drawing.Point(25, 186);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(55, 20);
            this.lblEMail.TabIndex = 12;
            this.lblEMail.Text = "E-mail:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 13;
            // 
            // FormRegCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 551);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEMail);
            this.Name = "FormRegCliente";
            this.Text = "Nuevo cliente";
            this.Controls.SetChildIndex(this.lblEMail, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox textBox1;
    }
}