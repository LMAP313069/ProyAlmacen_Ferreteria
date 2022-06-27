namespace ProyAlmacen_GUI
{
    partial class FrmConsProductoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsProductoProveedor));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtCodProv = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_unidMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stockAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtCodProv);
            this.grpDatos.Controls.Add(this.btnConsultar);
            this.grpDatos.Controls.Add(this.cboProveedor);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(12, 1);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(1115, 68);
            this.grpDatos.TabIndex = 6;
            this.grpDatos.TabStop = false;
            // 
            // txtCodProv
            // 
            this.txtCodProv.BackColor = System.Drawing.Color.Silver;
            this.txtCodProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProv.Location = new System.Drawing.Point(509, 26);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(90, 23);
            this.txtCodProv.TabIndex = 24;
            this.txtCodProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.Image = global::ProyAlmacen_GUI.Properties.Resources.Buscar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(623, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 33);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(298, 26);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(205, 23);
            this.cboProveedor.TabIndex = 0;
            this.cboProveedor.SelectionChangeCommitted += new System.EventHandler(this.cboProveedor_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(149, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccione Proveedor :";
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.AllowUserToDeleteRows = false;
            this.dtgProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Producto,
            this.prod_nom,
            this.prod_descr,
            this.prod_marca,
            this.prod_unidMed,
            this.prod_PrecioCompra,
            this.prod_stockMin,
            this.prod_stockAct,
            this.prod_estado,
            this.id_Categoria,
            this.id_Proveedor});
            this.dtgProducto.Location = new System.Drawing.Point(12, 80);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersVisible = false;
            this.dtgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducto.Size = new System.Drawing.Size(1115, 278);
            this.dtgProducto.TabIndex = 7;
            // 
            // id_Producto
            // 
            this.id_Producto.DataPropertyName = "id_Producto";
            this.id_Producto.HeaderText = "Codigo";
            this.id_Producto.Name = "id_Producto";
            this.id_Producto.ReadOnly = true;
            // 
            // prod_nom
            // 
            this.prod_nom.DataPropertyName = "prod_nom";
            this.prod_nom.HeaderText = "Producto";
            this.prod_nom.Name = "prod_nom";
            this.prod_nom.ReadOnly = true;
            // 
            // prod_descr
            // 
            this.prod_descr.DataPropertyName = "prod_descr";
            this.prod_descr.HeaderText = "Descripción";
            this.prod_descr.Name = "prod_descr";
            this.prod_descr.ReadOnly = true;
            // 
            // prod_marca
            // 
            this.prod_marca.DataPropertyName = "prod_marca";
            this.prod_marca.HeaderText = "Marca";
            this.prod_marca.Name = "prod_marca";
            this.prod_marca.ReadOnly = true;
            // 
            // prod_unidMed
            // 
            this.prod_unidMed.DataPropertyName = "prod_unidMed";
            this.prod_unidMed.HeaderText = "Unidad Med.";
            this.prod_unidMed.Name = "prod_unidMed";
            this.prod_unidMed.ReadOnly = true;
            // 
            // prod_PrecioCompra
            // 
            this.prod_PrecioCompra.DataPropertyName = "prod_PrecioCompra";
            this.prod_PrecioCompra.HeaderText = "Precio";
            this.prod_PrecioCompra.Name = "prod_PrecioCompra";
            this.prod_PrecioCompra.ReadOnly = true;
            // 
            // prod_stockMin
            // 
            this.prod_stockMin.DataPropertyName = "prod_stockMin";
            this.prod_stockMin.HeaderText = "Stock Min.";
            this.prod_stockMin.Name = "prod_stockMin";
            this.prod_stockMin.ReadOnly = true;
            // 
            // prod_stockAct
            // 
            this.prod_stockAct.DataPropertyName = "prod_stockAct";
            this.prod_stockAct.HeaderText = "Stock Actual";
            this.prod_stockAct.Name = "prod_stockAct";
            this.prod_stockAct.ReadOnly = true;
            // 
            // prod_estado
            // 
            this.prod_estado.DataPropertyName = "prod_estado";
            this.prod_estado.HeaderText = "Estado";
            this.prod_estado.Name = "prod_estado";
            this.prod_estado.ReadOnly = true;
            this.prod_estado.Visible = false;
            // 
            // id_Categoria
            // 
            this.id_Categoria.DataPropertyName = "id_Categoria";
            this.id_Categoria.HeaderText = "Categoria";
            this.id_Categoria.Name = "id_Categoria";
            this.id_Categoria.ReadOnly = true;
            this.id_Categoria.Visible = false;
            // 
            // id_Proveedor
            // 
            this.id_Proveedor.DataPropertyName = "id_Proveedor";
            this.id_Proveedor.HeaderText = "Proveedor";
            this.id_Proveedor.Name = "id_Proveedor";
            this.id_Proveedor.ReadOnly = true;
            this.id_Proveedor.Visible = false;
            // 
            // FrmConsProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 389);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsProductoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar producto por proveedor";
            this.Load += new System.EventHandler(this.FrmConsProductoProveedor_Load);
            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        internal System.Windows.Forms.Label txtCodProv;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboProveedor;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_unidMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stockAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Proveedor;
    }
}