using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyAlmacen_BE;
using ProyAlmacen_BL;

namespace ProyAlmacen_GUI
{
    public partial class FrmUsuarioMan02 : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        public FrmUsuarioMan02()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtContraseña.Text.Equals(txtConfirmar.Text))
            {
                try
                {
                    objEmpleadoBE.id_Empleado = txtCodigo.Text.Trim();
                    objEmpleadoBE.contraseña = txtContraseña.Text.Trim();

                    if (objEmpleadoBL.RegistrarUsuario(objEmpleadoBE) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar, verifique", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarioMan02_Load(object sender, EventArgs e)
        {
            try
            {
                cboEmpleado.DataSource = objEmpleadoBL.ListarEmpleadoSinUsuario();
                cboEmpleado.ValueMember = "id_Empleado";
                cboEmpleado.DisplayMember = "NOMBRES";
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(cboEmpleado.SelectedValue.ToString());
                txtCodigo.Text = cboEmpleado.SelectedValue.ToString();
                txtDNI.Text = objEmpleadoBE.Emp_Dni;
                txtUsuario.Text = objEmpleadoBE.Emp_Dni;

   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : No hay empleados disponibles");
                this.Close();
            }
        }

        private void cboEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtCodigo.Text = cboEmpleado.SelectedValue.ToString();
            objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(cboEmpleado.SelectedValue.ToString());
            txtDNI.Text = objEmpleadoBE.Emp_Dni;
            txtUsuario.Text = objEmpleadoBE.Emp_Dni;
        }

        private void FrmUsuarioMan02_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Control c in grpDatos.Controls) // recorre todos mis controles
            {
                if (c is TextBox)               // pregunta si es textBox
                {
                    if (c.Text == string.Empty)   // pregunto si esta vacia (vasta que una esta vacia)
                    {
                        btnGuardar.Enabled = false;  //  Desabilita el boton btnGrabar
                        return;
                    }
                }
            }
            btnGuardar.Enabled = true; //  habilita el boton btnGrabar
        }
    }
}
