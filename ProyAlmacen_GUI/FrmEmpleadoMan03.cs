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


    public partial class FrmEmpleadoMan03 : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        public FrmEmpleadoMan03()
        {
            InitializeComponent();

            dtpFN.MinDate = DateTime.Today.Subtract(TimeSpan.FromDays(16425)); // No Mayor de 45 años
            dtpFN.MaxDate = DateTime.Today.Subtract(TimeSpan.FromDays(6570)); // Mayor de 18 años
        }


        private String mvarcodigo;

        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }


      


        private void btnGuardar_Click(object sender, EventArgs e)
        {

          
                try
                {
                    //Codifique
                    objEmpleadoBE.id_Empleado = this.Codigo;
                    objEmpleadoBE.Emp_Nom = txtNombre.Text.Trim();
                    objEmpleadoBE.Emp_ApeP = txtAP.Text.Trim();
                    objEmpleadoBE.Emp_ApeM = txtAM.Text.Trim();
                    objEmpleadoBE.Emp_Telef = txtTelefono.Text.Trim();
                    objEmpleadoBE.Emp_Dni = txtDNI.Text.Trim();
                    objEmpleadoBE.Emp_Direc = txtDireccion.Text.Trim();
                    objEmpleadoBE.Emp_fechaNac = dtpFN.Value;
                    objEmpleadoBE.id_Cargo = cboCargo.SelectedValue.ToString();



                    if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
                    {
                        this.Close();


                    }
                    else
                    {

                        throw new Exception("Error, Verifique lo datos");

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

        private void FrmEmpleadoMan03_Load(object sender, EventArgs e)
        {
            try
            {

                //Llenar el combo con los Cargo
                cboCargo.DataSource = objEmpleadoBL.ListarCargo();
                cboCargo.ValueMember = "id_Cargo";
                cboCargo.DisplayMember = "Cargo_nom";



                //Codifique
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.Codigo);
                txtNombre.Text = objEmpleadoBE.Emp_Nom;
                txtAP.Text = objEmpleadoBE.Emp_ApeP;
                txtAM.Text = objEmpleadoBE.Emp_ApeM;
                txtTelefono.Text = objEmpleadoBE.Emp_Telef;
                txtDNI.Text = objEmpleadoBE.Emp_Dni;
                txtDireccion.Text = objEmpleadoBE.Emp_Direc;
                dtpFN.Value= objEmpleadoBE.Emp_fechaNac;
                cboCargo.SelectedValue = objEmpleadoBE.id_Cargo;

              
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }



        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
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

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim().Length != 8 & txtDNI.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El Dni consta de 8 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.SelectAll();
            }
        }

        private void FrmEmpleadoMan03_KeyUp(object sender, KeyEventArgs e)
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
