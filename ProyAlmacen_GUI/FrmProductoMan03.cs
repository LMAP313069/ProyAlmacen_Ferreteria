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
    public partial class FrmProductoMan03 : Form
    {
        CategoriaBL objCategoriaBL = new CategoriaBL();
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        public FrmProductoMan03()
        {
            InitializeComponent();
        }


  


        private String mvarcodigo;

        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }

        private void FrmProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenar los combos
                cboCategoria.DataSource = objCategoriaBL.ListarCategoriaNombre();
                cboCategoria.ValueMember = "id_Categoria";
                cboCategoria.DisplayMember = "cat_nombre";
                
                cboProveedor.DataSource = objProveedorBL.ListarProveedorNombre();
                cboProveedor.ValueMember = "id_Proveedor";
                cboProveedor.DisplayMember = "razonSocial";
                txtCodProv.Text = cboProveedor.SelectedValue.ToString();
                //------

                //Llenar los campos
                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);
                txtNombre.Text = objProductoBE.Nom_prod;
                txtDescripcion.Text = objProductoBE.Descr_prod;
                cboProveedor.SelectedValue = objProductoBE.Proveedor_prod;
                txtMedida.Text = objProductoBE.Medida_prod;
                txtPrecio.Text = objProductoBE.PrecioCom_prod.ToString();
                cboCategoria.SelectedValue = objProductoBE.Categoria_prod;
                txtMarca.Text = objProductoBE.Marca_prod;
                numStockMin.Value = objProductoBE.StockMin_prod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
                try
                {
                    //Codifique
                    objProductoBE.Cod_Prod = this.Codigo;
                    objProductoBE.Nom_prod = txtNombre.Text.Trim();
                    objProductoBE.Descr_prod = txtDescripcion.Text.Trim();
                    objProductoBE.Marca_prod = txtMarca.Text.Trim();
                    objProductoBE.Medida_prod = txtMedida.Text.Trim();
                    objProductoBE.PrecioCom_prod = Convert.ToSingle(txtPrecio.Text.Trim());
                    objProductoBE.StockMin_prod = Convert.ToInt16(numStockMin.Value);
                    objProductoBE.Categoria_prod = cboCategoria.SelectedValue.ToString();
                    objProductoBE.Proveedor_prod = cboProveedor.SelectedValue.ToString();



                    if (objProductoBL.ActualizarProducto(objProductoBE) == true)
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

        private void cboProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCodProv.Text = cboProveedor.SelectedValue.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void numStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnGuardar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void FrmProductoMan03_KeyUp(object sender, KeyEventArgs e)
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
