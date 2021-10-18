
namespace Formularios
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtBoxIdProd = new System.Windows.Forms.TextBox();
            this.dataGridViewVentaEnCurso = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCuotasOVuelto = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.txtBoxPago = new System.Windows.Forms.TextBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalCuotas = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.ckboxEnvio = new System.Windows.Forms.CheckBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCostodeEnvio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentaEnCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(254, 414);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 97);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(412, 58);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 29;
            this.dataGridViewProductos.Size = new System.Drawing.Size(376, 479);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.Location = new System.Drawing.Point(134, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblID.Location = new System.Drawing.Point(21, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdProducto.Location = new System.Drawing.Point(21, 65);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(91, 20);
            this.lblIdProducto.TabIndex = 4;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // txtBoxIdProd
            // 
            this.txtBoxIdProd.Location = new System.Drawing.Point(134, 62);
            this.txtBoxIdProd.Name = "txtBoxIdProd";
            this.txtBoxIdProd.Size = new System.Drawing.Size(113, 27);
            this.txtBoxIdProd.TabIndex = 5;
            // 
            // dataGridViewVentaEnCurso
            // 
            this.dataGridViewVentaEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentaEnCurso.Location = new System.Drawing.Point(21, 140);
            this.dataGridViewVentaEnCurso.Name = "dataGridViewVentaEnCurso";
            this.dataGridViewVentaEnCurso.RowHeadersWidth = 51;
            this.dataGridViewVentaEnCurso.RowTemplate.Height = 29;
            this.dataGridViewVentaEnCurso.Size = new System.Drawing.Size(354, 208);
            this.dataGridViewVentaEnCurso.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(21, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // cmbBoxFiltrar
            // 
            this.cmbBoxFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFiltrar.FormattingEnabled = true;
            this.cmbBoxFiltrar.Location = new System.Drawing.Point(572, 19);
            this.cmbBoxFiltrar.Name = "cmbBoxFiltrar";
            this.cmbBoxFiltrar.Size = new System.Drawing.Size(112, 28);
            this.cmbBoxFiltrar.Sorted = true;
            this.cmbBoxFiltrar.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(699, 18);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 29);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(281, 98);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forma de Pago:";
            // 
            // cmbBoxPago
            // 
            this.cmbBoxPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPago.FormattingEnabled = true;
            this.cmbBoxPago.Items.AddRange(new object[] {
            "Credito",
            "Debito",
            "Efectivo"});
            this.cmbBoxPago.Location = new System.Drawing.Point(149, 414);
            this.cmbBoxPago.Name = "cmbBoxPago";
            this.cmbBoxPago.Size = new System.Drawing.Size(99, 28);
            this.cmbBoxPago.TabIndex = 13;
            this.cmbBoxPago.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto Abonado:";
            // 
            // lblCuotasOVuelto
            // 
            this.lblCuotasOVuelto.AutoSize = true;
            this.lblCuotasOVuelto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuotasOVuelto.Location = new System.Drawing.Point(21, 457);
            this.lblCuotasOVuelto.Name = "lblCuotasOVuelto";
            this.lblCuotasOVuelto.Size = new System.Drawing.Size(57, 20);
            this.lblCuotasOVuelto.TabIndex = 15;
            this.lblCuotasOVuelto.Text = "Cuotas:";
            this.lblCuotasOVuelto.Visible = false;
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "6",
            "9",
            "12"});
            this.cmbCuotas.Location = new System.Drawing.Point(149, 449);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(99, 28);
            this.cmbCuotas.TabIndex = 16;
            this.cmbCuotas.Visible = false;
            this.cmbCuotas.SelectedIndexChanged += new System.EventHandler(this.cmbCuotas_SelectedIndexChanged);
            // 
            // txtBoxPago
            // 
            this.txtBoxPago.Location = new System.Drawing.Point(149, 484);
            this.txtBoxPago.Name = "txtBoxPago";
            this.txtBoxPago.Size = new System.Drawing.Size(98, 27);
            this.txtBoxPago.TabIndex = 17;
            this.txtBoxPago.TextChanged += new System.EventHandler(this.txtBoxPago_TextChanged);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(134, 99);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(113, 27);
            this.txtBoxCantidad.TabIndex = 19;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(21, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblTotalCuotas
            // 
            this.lblTotalCuotas.AutoSize = true;
            this.lblTotalCuotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCuotas.Location = new System.Drawing.Point(208, 366);
            this.lblTotalCuotas.Name = "lblTotalCuotas";
            this.lblTotalCuotas.Size = new System.Drawing.Size(45, 20);
            this.lblTotalCuotas.TabIndex = 20;
            this.lblTotalCuotas.Text = "Total:";
            this.lblTotalCuotas.Visible = false;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCuota.Location = new System.Drawing.Point(202, 391);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(51, 20);
            this.lblCuota.TabIndex = 21;
            this.lblCuota.Text = "Cuota:";
            this.lblCuota.Visible = false;
            // 
            // ckboxEnvio
            // 
            this.ckboxEnvio.AutoSize = true;
            this.ckboxEnvio.Location = new System.Drawing.Point(21, 389);
            this.ckboxEnvio.Name = "ckboxEnvio";
            this.ckboxEnvio.Size = new System.Drawing.Size(67, 24);
            this.ckboxEnvio.TabIndex = 23;
            this.ckboxEnvio.Text = "Envio";
            this.ckboxEnvio.UseVisualStyleBackColor = true;
            this.ckboxEnvio.CheckStateChanged += new System.EventHandler(this.ckboxEnvio_CheckStateChanged);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDistancia.Location = new System.Drawing.Point(21, 520);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(73, 20);
            this.lblDistancia.TabIndex = 24;
            this.lblDistancia.Text = "Distancia:";
            this.lblDistancia.Visible = false;
            // 
            // lblCostodeEnvio
            // 
            this.lblCostodeEnvio.AutoSize = true;
            this.lblCostodeEnvio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCostodeEnvio.Location = new System.Drawing.Point(180, 520);
            this.lblCostodeEnvio.Name = "lblCostodeEnvio";
            this.lblCostodeEnvio.Size = new System.Drawing.Size(111, 20);
            this.lblCostodeEnvio.TabIndex = 25;
            this.lblCostodeEnvio.Text = "Costo de envio:";
            this.lblCostodeEnvio.Visible = false;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.lblCostodeEnvio);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.ckboxEnvio);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.lblTotalCuotas);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtBoxPago);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.lblCuotasOVuelto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbBoxFiltrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridViewVentaEnCurso);
            this.Controls.Add(this.txtBoxIdProd);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentaEnCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtBoxIdProd;
        private System.Windows.Forms.DataGridView dataGridViewVentaEnCurso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbBoxFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCuotasOVuelto;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.TextBox txtBoxPago;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalCuotas;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.CheckBox ckboxEnvio;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCostodeEnvio;
    }
}