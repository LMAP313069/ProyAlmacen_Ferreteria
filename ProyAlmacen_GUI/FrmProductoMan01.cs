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
    public partial class FrmProductoMan01 : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        public FrmProductoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtgProductos.DataSource = objProductoBL.ListarProductoActivo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProductoMan02 Prod01 = new FrmProductoMan02();
                Prod01.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProductoMan03 Prod03 = new FrmProductoMan03();
                Prod03.Codigo = dtgProductos.CurrentRow.Cells[0].Value.ToString();
                Prod03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                DialogResult vrpta;
                vrpta = MessageBox.Show("¿Estas seguro de eliminar el producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes)
                {
                    String codigo;
                    codigo = dtgProductos.CurrentRow.Cells[0].Value.ToString();

                    if (objProductoBL.EliminarProducto(codigo) == true)
                    {
                        CargarDatos();
                    }
                    else
                    {
                        throw new Exception("El intento fracaso.Verifique");
                    }
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
         }

        private void FrmProductoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
    }
}
