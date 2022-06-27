namespace ProyAlmacen_GUI
{
    partial class FrmEmpleadoMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleadoMan01));
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ApeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ApeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Telef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Direc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            this.dtgEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.Emp_Nom,
            this.Emp_ApeP,
            this.Emp_ApeM,
            this.Emp_Telef,
            this.Emp_Dni,
            this.Emp_Direc,
            this.Emp_Estado,
            this.Emp_FechaNac,
            this.contraseña,
            this.id_Cargo});
            this.dtgEmpleados.Location = new System.Drawing.Point(12, 91);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersVisible = false;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(974, 330);
            this.dtgEmpleados.TabIndex = 17;
            // 
            // id_Empleado
            // 
            this.id_Empleado.DataPropertyName = "id_Empleado";
            this.id_Empleado.HeaderText = "Codigo";
            this.id_Empleado.Name = "id_Empleado";
            this.id_Empleado.ReadOnly = true;
            // 
            // Emp_Nom
            // 
            this.Emp_Nom.DataPropertyName = "Emp_Nom";
            this.Emp_Nom.HeaderText = "Nombres";
            this.Emp_Nom.Name = "Emp_Nom";
            this.Emp_Nom.ReadOnly = true;
            // 
            // Emp_ApeP
            // 
            this.Emp_ApeP.DataPropertyName = "Emp_ApeP";
            this.Emp_ApeP.HeaderText = "Apellido P.";
            this.Emp_ApeP.Name = "Emp_ApeP";
            this.Emp_ApeP.ReadOnly = true;
            // 
            // Emp_ApeM
            // 
            this.Emp_ApeM.DataPropertyName = "Emp_ApeM";
            this.Emp_ApeM.HeaderText = "Apellido M.";
            this.Emp_ApeM.Name = "Emp_ApeM";
            this.Emp_ApeM.ReadOnly = true;
            // 
            // Emp_Telef
            // 
            this.Emp_Telef.DataPropertyName = "Emp_Telef";
            this.Emp_Telef.HeaderText = "Telefono";
            this.Emp_Telef.Name = "Emp_Telef";
            this.Emp_Telef.ReadOnly = true;
            // 
            // Emp_Dni
            // 
            this.Emp_Dni.DataPropertyName = "Emp_Dni";
            this.Emp_Dni.HeaderText = "DNI";
            this.Emp_Dni.Name = "Emp_Dni";
            this.Emp_Dni.ReadOnly = true;
            // 
            // Emp_Direc
            // 
            this.Emp_Direc.DataPropertyName = "Emp_Direc";
            this.Emp_Direc.HeaderText = "Dirección";
            this.Emp_Direc.Name = "Emp_Direc";
            this.Emp_Direc.ReadOnly = true;
            // 
            // Emp_Estado
            // 
            this.Emp_Estado.DataPropertyName = "Emp_Estado";
            this.Emp_Estado.HeaderText = "Estado";
            this.Emp_Estado.Name = "Emp_Estado";
            this.Emp_Estado.ReadOnly = true;
            this.Emp_Estado.Visible = false;
            // 
            // Emp_FechaNac
            // 
            this.Emp_FechaNac.DataPropertyName = "Emp_FechaNac";
            this.Emp_FechaNac.HeaderText = "Fecha Nacimiento ";
            this.Emp_FechaNac.Name = "Emp_FechaNac";
            this.Emp_FechaNac.ReadOnly = true;
            this.Emp_FechaNac.Visible = false;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Visible = false;
            // 
            // id_Cargo
            // 
            this.id_Cargo.DataPropertyName = "id_Cargo";
            this.id_Cargo.HeaderText = "Cargo";
            this.id_Cargo.Name = "id_Cargo";
            this.id_Cargo.ReadOnly = true;
            this.id_Cargo.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(342, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "LISTA DE EMPLEADOS";
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
            // FrmEmpleadoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 518);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleadoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleadoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ApeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ApeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Telef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Direc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cargo;
    }
}