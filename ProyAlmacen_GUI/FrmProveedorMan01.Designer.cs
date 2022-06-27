namespace ProyAlmacen_GUI
{
    partial class FrmProveedorMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedorMan01));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direc_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tef_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contac_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
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
            this.btnSalir.Location = new System.Drawing.Point(894, 457);
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
            this.btnEliminar.Location = new System.Drawing.Point(808, 457);
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
            this.btnModificar.Location = new System.Drawing.Point(711, 457);
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
            this.btnAgregar.Location = new System.Drawing.Point(625, 457);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.AllowUserToResizeRows = false;
            this.dtgProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Proveedor,
            this.razonSocial,
            this.Direc_prov,
            this.Ruc_prov,
            this.tef_prov,
            this.Contac_prov,
            this.estado_prov,
            this.fechaRegistro});
            this.dtgProveedores.Location = new System.Drawing.Point(12, 91);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.RowHeadersVisible = false;
            this.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedores.Size = new System.Drawing.Size(974, 330);
            this.dtgProveedores.TabIndex = 23;
            // 
            // id_Proveedor
            // 
            this.id_Proveedor.DataPropertyName = "id_Proveedor";
            this.id_Proveedor.HeaderText = "Codigo";
            this.id_Proveedor.Name = "id_Proveedor";
            this.id_Proveedor.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // Direc_prov
            // 
            this.Direc_prov.DataPropertyName = "Direc_prov";
            this.Direc_prov.HeaderText = "Dirección";
            this.Direc_prov.Name = "Direc_prov";
            this.Direc_prov.ReadOnly = true;
            // 
            // Ruc_prov
            // 
            this.Ruc_prov.DataPropertyName = "Ruc_prov";
            this.Ruc_prov.HeaderText = "Ruc";
            this.Ruc_prov.Name = "Ruc_prov";
            this.Ruc_prov.ReadOnly = true;
            // 
            // tef_prov
            // 
            this.tef_prov.DataPropertyName = "tef_prov";
            this.tef_prov.HeaderText = "Telefono";
            this.tef_prov.Name = "tef_prov";
            this.tef_prov.ReadOnly = true;
            // 
            // Contac_prov
            // 
            this.Contac_prov.DataPropertyName = "Contac_prov";
            this.Contac_prov.HeaderText = "Contacto";
            this.Contac_prov.Name = "Contac_prov";
            this.Contac_prov.ReadOnly = true;
            // 
            // estado_prov
            // 
            this.estado_prov.DataPropertyName = "estado_prov";
            this.estado_prov.HeaderText = "Estado";
            this.estado_prov.Name = "estado_prov";
            this.estado_prov.ReadOnly = true;
            this.estado_prov.Visible = false;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(322, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "LISTA DE PROVEEDORES";
            // 
            // FrmProveedorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 518);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProveedores);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProveedorMan01";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direc_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn tef_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contac_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
    }
}