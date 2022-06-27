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
    public partial class FrmProveedorMan03 : Form
    {
        ProveedorBE objProveedorBE = new ProveedorBE();
        ProveedorBL objProveedorBL = new ProveedorBL();

        public FrmProveedorMan03()
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
            try
            {
                //Codifique
                objProveedorBE.Cod_Prov = this.Codigo;
                objProveedorBE.Raz_prov = txtRS.Text.Trim();
                objProveedorBE.Direc_prov = txtDireccion.Text.Trim();
                objProveedorBE.Ruc_prov = txtRUC.Text.Trim();
                objProveedorBE.Telf_prov = txtTelf.Text.Trim();
                objProveedorBE.Contac_prov = txtContacto.Text.Trim();

                if (objProveedorBL.ActualizarProveedor(objProveedorBE) == true)
                {
                    this.Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                String varestado;
                //Codifique
                objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);
                txtRS.Text = objProveedorBE.Raz_prov;
                txtDireccion.Text = objProveedorBE.Direc_prov;
                txtRUC.Text = objProveedorBE.Ruc_prov;
                txtTelf.Text = objProveedorBE.Telf_prov;
                txtContacto.Text = objProveedorBE.Contac_prov;
                varestado = objProveedorBE.Estado_prov;

                if (varestado.Equals("A"))
                {
                    txtEstado.Text = "Activo";
                }else
                {
                    txtEstado.Text = "Inactivo";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void txtRS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
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

        private void FrmProveedorMan03_KeyUp(object sender, KeyEventArgs e)
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
