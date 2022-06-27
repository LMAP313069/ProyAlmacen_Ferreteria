namespace ProyAlmacen_GUI
{
    partial class FrmProductoMan03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoMan03));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.numStockMin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodProv = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.Label5);
            this.grpDatos.Controls.Add(this.numStockMin);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.txtCodProv);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.txtMedida);
            this.grpDatos.Controls.Add(this.cboProveedor);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.cboCategoria);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtDescripcion);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.txtMarca);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(10, 11);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(467, 302);
            this.grpDatos.TabIndex = 5;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(233, 157);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 18);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Precio Compra :";
            // 
            // numStockMin
            // 
            this.numStockMin.Location = new System.Drawing.Point(119, 214);
            this.numStockMin.Name = "numStockMin";
            this.numStockMin.Size = new System.Drawing.Size(44, 22);
            this.numStockMin.TabIndex = 7;
            this.numStockMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numStockMin_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Stock Min :";
            // 
            // txtCodProv
            // 
            this.txtCodProv.BackColor = System.Drawing.Color.Silver;
            this.txtCodProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProv.Location = new System.Drawing.Point(339, 127);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(90, 23);
            this.txtCodProv.TabIndex = 24;
            this.txtCodProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Image = global::ProyAlmacen_GUI.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(248, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Image = global::ProyAlmacen_GUI.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(119, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnGuardar_KeyUp);
            // 
            // txtMedida
            // 
            this.txtMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.Location = new System.Drawing.Point(119, 157);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(96, 21);
            this.txtMedida.TabIndex = 3;
            this.txtMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(119, 127);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(205, 23);
            this.cboProveedor.TabIndex = 2;
            this.cboProveedor.SelectionChangeCommitted += new System.EventHandler(this.cboProveedor_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Proveedor :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoria :";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(119, 185);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(125, 23);
            this.cboCategoria.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(78, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 21);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(11, 73);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(436, 48);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(339, 156);
            this.txtPrecio.MaxLength = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(96, 21);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(339, 185);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(96, 21);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Descripcion : ";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(260, 186);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Marca : ";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 161);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(118, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Und. de Medida :";
            // 
            // FrmProductoMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 325);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductoMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FrmProductoMan03_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProductoMan03_KeyUp);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.NumericUpDown numStockMin;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label txtCodProv;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.ComboBox cboProveedor;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCategoria;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.TextBox txtMarca;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
    }
}