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
    public partial class FrmProveedorMan02 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
        public FrmProveedorMan02()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                objProveedorBE.Raz_prov = txtRS.Text.Trim();
                objProveedorBE.Direc_prov = txtDireccion.Text.Trim();
                objProveedorBE.Ruc_prov = txtRUC.Text.Trim();
                objProveedorBE.Telf_prov = txtTelf.Text.Trim();
                objProveedorBE.Contac_prov = txtContacto.Text.Trim();


                if (objProveedorBL.InsertarProveedor(objProveedorBE) == true)
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

        private void FrmProveedorMan02_Load(object sender, EventArgs e)
        {

        }

        private void txtRS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void FrmProveedorMan02_KeyUp(object sender, KeyEventArgs e)
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

        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (txtRUC.Text.Trim().Length != 11 & txtRUC.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El Ruc consta de 11 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRUC.SelectAll();
            }
        }

        private void txtTelf_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelf.Text.Trim().Length != 9 & txtTelf.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El Telefono consta de 9 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelf.SelectAll();
            }
        }
    }
}
