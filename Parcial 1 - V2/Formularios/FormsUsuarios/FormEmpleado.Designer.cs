
namespace Formularios
{
    partial class FormEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.txtBoxBuscarU = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBienvenido.Location = new System.Drawing.Point(15, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(81, 15);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Hola, Usuario!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Location = new System.Drawing.Point(19, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 68);
            this.panel1.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogOut.Location = new System.Drawing.Point(755, 2);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(67, 22);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatos.Location = new System.Drawing.Point(299, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(317, 15);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos del tipito: nombre, apellido, fecha de nacimiento, rol";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.GreenYellow;
            this.btnClientes.Location = new System.Drawing.Point(19, 169);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(282, 44);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.GreenYellow;
            this.btnProductos.Location = new System.Drawing.Point(19, 120);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(282, 44);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(318, 120);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(525, 235);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(614, 94);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.Visible = false;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(668, 92);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(177, 23);
            this.txtBoxBuscar.TabIndex = 13;
            this.txtBoxBuscar.Visible = false;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscarProd_TextChanged);
            // 
            // txtBoxBuscarU
            // 
            this.txtBoxBuscarU.Location = new System.Drawing.Point(668, 92);
            this.txtBoxBuscarU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBuscarU.Name = "txtBoxBuscarU";
            this.txtBoxBuscarU.Size = new System.Drawing.Size(177, 23);
            this.txtBoxBuscarU.TabIndex = 14;
            this.txtBoxBuscarU.Visible = false;
            this.txtBoxBuscarU.TextChanged += new System.EventHandler(this.txtBoxBuscarU_TextChanged);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(869, 370);
            this.Controls.Add(this.txtBoxBuscarU);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Pet Store";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscarU;
    }
}