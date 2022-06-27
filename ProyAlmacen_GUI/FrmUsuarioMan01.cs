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
    public partial class FrmUsuarioMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        public FrmUsuarioMan01()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            dtgUsuarios.DataSource = objEmpleadoBL.ListarEmpleadoConUsuario();
        }

        private void FrmUsuarioMan01_Load(object sender, EventArgs e)
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
                FrmUsuarioMan02 User01 = new FrmUsuarioMan02();
                User01.ShowDialog();
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
                FrmUsuarioMan03 User03 = new FrmUsuarioMan03();
                User03.Codigo = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
                User03.ShowDialog();
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
                vrpta = MessageBox.Show("¿Estas seguro de eliminar al usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes)
                {
                    String codigo;
                    codigo = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();

                    if (objEmpleadoBL.EliminarUsuario(codigo) == true)
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
    }
}
