namespace ProyAlmacen_GUI
{
    partial class FrmProductoMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoMan01));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_unidMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stockAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::ProyAlmacen_GUI.Properties.Resources.Shutdown_32x32_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(894, 456);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = global::ProyAlmacen_GUI.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(808, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.Image = global::ProyAlmacen_GUI.Properties.Resources.Editar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(711, 456);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.Image = global::ProyAlmacen_GUI.Properties.Resources.Agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(625, 456);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Producto,
            this.prod_nom,
            this.prod_descr,
            this.id_Categoria,
            this.prod_marca,
            this.id_Proveedor,
            this.prod_unidMed,
            this.prod_PrecioCompra,
            this.prod_StockMin,
            this.prod_stockAct,
            this.prod_estado});
            this.dtgProductos.Location = new System.Drawing.Point(12, 90);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowHeadersVisible = false;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(974, 330);
            this.dtgProductos.TabIndex = 11;
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
            // id_Categoria
            // 
            this.id_Categoria.DataPropertyName = "id_Categoria";
            this.id_Categoria.HeaderText = "Categoria";
            this.id_Categoria.Name = "id_Categoria";
            this.id_Categoria.ReadOnly = true;
            this.id_Categoria.Visible = false;
            // 
            // prod_marca
            // 
            this.prod_marca.DataPropertyName = "prod_marca";
            this.prod_marca.HeaderText = "Marca";
            this.prod_marca.Name = "prod_marca";
            this.prod_marca.ReadOnly = true;
            // 
            // id_Proveedor
            // 
            this.id_Proveedor.DataPropertyName = "id_Proveedor";
            this.id_Proveedor.HeaderText = "Proveedor";
            this.id_Proveedor.Name = "id_Proveedor";
            this.id_Proveedor.ReadOnly = true;
            this.id_Proveedor.Visible = false;
            // 
            // prod_unidMed
            // 
            this.prod_unidMed.DataPropertyName = "prod_unidMed";
            this.prod_unidMed.HeaderText = "Unidad M.";
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
            // prod_StockMin
            // 
            this.prod_StockMin.DataPropertyName = "prod_stockMin";
            this.prod_StockMin.HeaderText = "Stock Min.";
            this.prod_StockMin.Name = "prod_StockMin";
            this.prod_StockMin.ReadOnly = true;
            this.prod_StockMin.Visible = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(339, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // FrmProductoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 518);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FrmProductoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_unidMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_StockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stockAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estado;
    }
}