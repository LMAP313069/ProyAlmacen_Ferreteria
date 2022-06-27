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

namespace ProyAlmacen_GUI
{
    public partial class FrmConsProductoProveedor : Form
    {
        public FrmConsProductoProveedor()
        {
            InitializeComponent();
        }
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProductoBL objProductoBL = new ProductoBL();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgProducto.DataSource = objProductoBL.ListarProductoProveedor(cboProveedor.SelectedValue.ToString());
                if (dtgProducto.Rows.Count == 0)
                {
                    throw new Exception("En proveedor no tiene productos activos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void FrmConsProductoProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenar el combo con los proveedores
                cboProveedor.DataSource = objProveedorBL.ListarProveedoresActivos();
                cboProveedor.ValueMember = "id_proveedor";
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
    }
}
