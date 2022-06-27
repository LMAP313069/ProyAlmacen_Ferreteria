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
    public partial class FrmEmpleadoMan01 : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        public FrmEmpleadoMan01()
        {
            InitializeComponent();
        }



        public void CargarDatos()
        {
            dtgEmpleados.DataSource = objEmpleadoBL.ListarEmpleadoActivo();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEmpleadoMan02 Emp02 = new FrmEmpleadoMan02();
                Emp02.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }




        }

        private void FrmEmpleadoMan01_Load(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                FrmEmpleadoMan03 Emp03 = new FrmEmpleadoMan03();
                Emp03.Codigo = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
                Emp03.ShowDialog();
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
                    codigo = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();

                    if (objEmpleadoBL.EliminarEmpleado(codigo) == true)
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
