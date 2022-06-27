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
    public partial class FrmProveedorMan01 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();

        public FrmProveedorMan01()
        {
            InitializeComponent();
        }
        private String mvarcodigo;

        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }
        public void CargarDatos()
        {
            dtgProveedores.DataSource = objProveedorBL.ListarProveedoresActivos();
        }

        private void FrmProveedorMan01_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                FrmProveedorMan02 prod02 = new FrmProveedorMan02();
                prod02.ShowDialog();
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
                //Codifique
                FrmProveedorMan03 prod03 = new FrmProveedorMan03();
                prod03.Codigo = dtgProveedores.CurrentRow.Cells[0].Value.ToString();
                prod03.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                DialogResult vrpta;
                vrpta = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes)
                {
                    String codigo;
                    codigo = dtgProveedores.CurrentRow.Cells[0].Value.ToString();

                    if (objProveedorBL.EliminarProveedor(codigo) == true)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
