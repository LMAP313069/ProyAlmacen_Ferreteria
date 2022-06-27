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
    public partial class FrmEmpleadoMan02 : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        public FrmEmpleadoMan02()
        {
            InitializeComponent();

            dtpFN.MinDate = DateTime.Today.Subtract(TimeSpan.FromDays(16425)); // No Mayor de 45 años
            dtpFN.MaxDate = DateTime.Today.Subtract(TimeSpan.FromDays(6570)); // Mayor de 18 años
            btnGuardar.Enabled = false;
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
                try
                {

                    objEmpleadoBE.Emp_Nom = txtNombre.Text.Trim();
                    objEmpleadoBE.Emp_ApeP = txtAP.Text.Trim();
                    objEmpleadoBE.Emp_ApeM = txtAM.Text.Trim();
                    objEmpleadoBE.Emp_Telef = txtTelefono.Text.Trim();
                    objEmpleadoBE.Emp_Dni = txtDni.Text.Trim();
                    objEmpleadoBE.Emp_Direc = txtDireccion.Text.Trim();
                    objEmpleadoBE.Emp_fechaNac = dtpFN.Value;
                    objEmpleadoBE.id_Cargo = cboCargo.SelectedValue.ToString();

                    if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleadoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenar el combo con los Cargo
                cboCargo.DataSource = objEmpleadoBL.ListarCargo();
                cboCargo.ValueMember = "id_Cargo";
                cboCargo.DisplayMember = "Cargo_nom";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void FrmEmpleadoMan02_KeyUp(object sender, KeyEventArgs e)
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (txtDni.Text.Trim().Length != 8 & txtDni.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El Dni consta de 8 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.SelectAll();
            }
        }

        private void txtDni_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)  // si es el click derecho
            {
                MessageBox.Show("Accion Invalida");

            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Trim().Length != 9 & txtTelefono.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El Telefono consta de 9 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.SelectAll();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
