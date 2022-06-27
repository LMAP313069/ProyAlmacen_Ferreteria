namespace ProyAlmacen_GUI
{
    partial class FrmUsuarioMan01
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ApeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_ApeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Telef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Direc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.dtgUsuarios);
            this.grpDatos.Controls.Add(this.btnEliminar);
            this.grpDatos.Controls.Add(this.btnModificar);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(12, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(706, 268);
            this.grpDatos.TabIndex = 6;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Usuarios Registrados";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToResizeRows = false;
            this.dtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.Emp_Nom,
            this.Emp_ApeP,
            this.Emp_ApeM,
            this.Emp_Telef,
            this.Emp_Dni,
            this.Emp_Direc,
            this.Emp_Estado,
            this.Emp_fechaNac,
            this.contraseña,
            this.id_Cargo});
            this.dtgUsuarios.Location = new System.Drawing.Point(17, 32);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(673, 174);
            this.dtgUsuarios.TabIndex = 29;
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
            this.Emp_Nom.HeaderText = "Nombres ";
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
            this.Emp_ApeM.Visible = false;
            // 
            // Emp_Telef
            // 
            this.Emp_Telef.DataPropertyName = "Emp_Telef";
            this.Emp_Telef.HeaderText = "Telefono";
            this.Emp_Telef.Name = "Emp_Telef";
            this.Emp_Telef.ReadOnly = true;
            this.Emp_Telef.Visible = false;
            // 
            // Emp_Dni
            // 
            this.Emp_Dni.DataPropertyName = "Emp_Dni";
            this.Emp_Dni.HeaderText = "Dni";
            this.Emp_Dni.Name = "Emp_Dni";
            this.Emp_Dni.ReadOnly = true;
            // 
            // Emp_Direc
            // 
            this.Emp_Direc.DataPropertyName = "Emp_Direc";
            this.Emp_Direc.HeaderText = "Dirección";
            this.Emp_Direc.Name = "Emp_Direc";
            this.Emp_Direc.ReadOnly = true;
            this.Emp_Direc.Visible = false;
            // 
            // Emp_Estado
            // 
            this.Emp_Estado.DataPropertyName = "Emp_Estado";
            this.Emp_Estado.HeaderText = "Estado";
            this.Emp_Estado.Name = "Emp_Estado";
            this.Emp_Estado.ReadOnly = true;
            this.Emp_Estado.Visible = false;
            // 
            // Emp_fechaNac
            // 
            this.Emp_fechaNac.DataPropertyName = "Emp_fechaNac";
            this.Emp_fechaNac.HeaderText = "Fecha Nacimiento";
            this.Emp_fechaNac.Name = "Emp_fechaNac";
            this.Emp_fechaNac.ReadOnly = true;
            this.Emp_fechaNac.Visible = false;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            // 
            // id_Cargo
            // 
            this.id_Cargo.DataPropertyName = "id_Cargo";
            this.id_Cargo.HeaderText = "Cargo";
            this.id_Cargo.Name = "id_Cargo";
            this.id_Cargo.ReadOnly = true;
            this.id_Cargo.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = global::ProyAlmacen_GUI.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(486, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
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
            this.btnModificar.Location = new System.Drawing.Point(399, 212);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
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
            this.btnAgregar.Location = new System.Drawing.Point(313, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 37);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmUsuarioMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 306);
            this.Controls.Add(this.grpDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarioMan01_Load);
            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ApeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ApeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Telef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Direc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cargo;
    }
}