using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
namespace ProyAlmacen_GUI
{
    public partial class FrmMDIU : Form
    {


        // PERMITE DEVOLVER EL ESTACIO DE TIEMPO TRANSCURRIDO

        TimeSpan horaentrada = new TimeSpan();
        //  No olvidar referenciar el namespace Microsoft.VisualBasic.Devices

        Computer myComputer = new Computer();
        String myRed = "";
        Boolean reiniciar = false;
        public FrmMDIU( string nombre)
        {
            InitializeComponent();
            lblUser.Text = nombre;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            // DateTime.Now = DEVUELVE LA HORA Y FECHA ACTUAL

            this.Text = "Sistemas IECA da la hora : " + DateTime.Now;

            //Almacenamos, la hora actual , el Substring agregamos el numero de caracteres (0,8)

            lblSesion.Text = "Tiempo de Sesion : " + DateTime.Now.TimeOfDay.Subtract(horaentrada).ToString().Substring(0, 8);


        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            // Capturas la hora que inicia sesion

            horaentrada = DateTime.Now.TimeOfDay;
            // establecemos si hay red o no ?
            if (myComputer.Network.IsAvailable)
            {

                myRed = "Sistema con conexion disponible";

            }
            else
            {
                myRed = "Sistema sin conexion disponible";


            }
            // Imprime el nombre de la PC y el estado de la Red

            lblUsuario.Text = "Maquina :" + myComputer.Name + " " + myRed;
        }

        private void FrmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir de la aplicacion??", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrpta == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (reiniciar == false)
            {

                Application.Exit();

            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reiniciar = true;
            this.Close();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reiniciar = false;
            this.Close();
        }

        private void ManEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleadoMan01 Emp01 = new FrmEmpleadoMan01();

            Emp01.ShowDialog();
        }

        private void ManProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedorMan01 Prv01 = new FrmProveedorMan01();

            Prv01.ShowDialog();
        }

        private void ManProducto_Click(object sender, EventArgs e)
        {
            FrmProductoMan01 Prd01 = new FrmProductoMan01();

            Prd01.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioMan01 User01 = new FrmUsuarioMan01();

            User01.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsProductoProveedor Prd01 = new FrmConsProductoProveedor();

            Prd01.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioMan03 User03 = new FrmUsuarioMan03();

            User03.ShowDialog();
        }
    }
}
