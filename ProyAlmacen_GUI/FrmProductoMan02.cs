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
    public partial class FrmProductoMan02 : Form
    {
        public FrmProductoMan02()
        {
            InitializeComponent();
        }

        CategoriaBL objCategoriaBL = new CategoriaBL();
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();



 


        private void FrmProductoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenar el combo con los distritos
                cboCategoria.DataSource = objCategoriaBL.ListarCategoriaNombre();
                cboCategoria.ValueMember = "id_Categoria";
                cboCategoria.DisplayMember = "cat_nombre";

                cboProveedor.DataSource = objProveedorBL.ListarProveedorNombre();
                cboProveedor.ValueMember = "id_Proveedor";
                cboProveedor.DisplayMember = "razonSocial";
                txtCodProv.Text = cboProveedor.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cboProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCodProv.Text = cboProveedor.SelectedValue.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
                try
                {

                    objProductoBE.Nom_prod = txtNombre.Text.Trim();
                    objProductoBE.Descr_prod = txtDescripcion.Text.Trim();
                    objProductoBE.Marca_prod = txtMarca.Text.Trim();
                    objProductoBE.Medida_prod = txtMedida.Text.Trim();
                    objProductoBE.PrecioCom_prod = Convert.ToSingle(txtPrecio.Text.Trim());
                    objProductoBE.StockMin_prod = Convert.ToInt16(numStockMin.Value);
                    objProductoBE.Categoria_prod = cboCategoria.SelectedValue.ToString();
                    objProductoBE.Proveedor_prod = cboProveedor.SelectedValue.ToString();
                    //lblSueldo.Text = vsueldo.ToString("###,##0.00 soles"); // <- FORMATO.

                    if (objProductoBL.InsertarProducto(objProductoBE) == true)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void FrmProductoMan02_KeyUp(object sender, KeyEventArgs e)
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
