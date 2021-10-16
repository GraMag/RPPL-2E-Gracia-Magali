
namespace Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtBxUsuario = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnEmpLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxUsuario
            // 
            this.txtBxUsuario.Location = new System.Drawing.Point(65, 87);
            this.txtBxUsuario.Name = "txtBxUsuario";
            this.txtBxUsuario.PlaceholderText = "Ingresar usuario";
            this.txtBxUsuario.Size = new System.Drawing.Size(285, 27);
            this.txtBxUsuario.TabIndex = 0;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(65, 120);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.PlaceholderText = "Ingresar contraseña";
            this.txtBxPassword.Size = new System.Drawing.Size(285, 27);
            this.txtBxPassword.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(130, 153);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(169, 47);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdminLogin.Location = new System.Drawing.Point(370, 12);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(32, 28);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "A";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnEmpLogin
            // 
            this.btnEmpLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEmpLogin.Location = new System.Drawing.Point(12, 12);
            this.btnEmpLogin.Name = "btnEmpLogin";
            this.btnEmpLogin.Size = new System.Drawing.Size(32, 32);
            this.btnEmpLogin.TabIndex = 5;
            this.btnEmpLogin.Text = "E";
            this.btnEmpLogin.UseVisualStyleBackColor = false;
            this.btnEmpLogin.Click += new System.EventHandler(this.btnEmpLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 207);
            this.ControlBox = false;
            this.Controls.Add(this.btnEmpLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUsuario;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEmpLogin;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}

