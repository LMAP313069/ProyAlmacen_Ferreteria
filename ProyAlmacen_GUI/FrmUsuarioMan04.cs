using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyAlmacen_BL;
using ProyAlmacen_BE;

namespace ProyAlmacen_GUI
{
    public partial class FrmUsuarioMan04 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        public FrmUsuarioMan04()
        {
            InitializeComponent();
        }

        private String mvarcodigo;

        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.Codigo);

            if (txtNuevaContraseña.Text.Equals(txtConfirmar.Text) & txtUltimaContraseña.Text.Equals(objEmpleadoBE.contraseña))
            {
                try
                {



                    objEmpleadoBE.id_Empleado = this.Codigo;
                    objEmpleadoBE.contraseña = txtNuevaContraseña.Text.Trim();

                    if (objEmpleadoBL.RegistrarUsuario(objEmpleadoBE) == true)
                    {

                        MessageBox.Show("Actualizado Exitosamente..!! ");
                        this.Close();
                        FrmLogin login = new FrmLogin();
                        login.Show();
                    }
                    else
                    {
                        throw new Exception("Error, Verifique los datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido el error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Verificar Contraseña");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarioMan04_KeyUp(object sender, KeyEventArgs e)
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
