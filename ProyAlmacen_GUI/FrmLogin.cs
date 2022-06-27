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
using System.Data.SqlClient;





namespace ProyAlmacen_GUI
{
    public partial class FrmLogin : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        int intentos = 0;
        int tiempo = 30;
        public FrmLogin()
        {
            InitializeComponent();
        }




        SqlConnection cnx = new SqlConnection("server=.;Database=Almacen_Ferreteria; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        Boolean blnexito = false;



        public Boolean Logear(string usuario, string contra)
        {


            //Agregamos parametros 
            try
            {


                cmd.Connection = cnx;
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDniContraseña";
                //Codifique
                cmd.Parameters.AddWithValue("@emp_dni", usuario);
                cmd.Parameters.AddWithValue("@contra", contra);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                blnexito = true;

                if (dt.Rows.Count == 1)
                {
                   


                    if (dt.Rows[0][1].ToString() == "Administrador(a)")
                    {
                        this.Hide();

                        this.Visible = true; // LUEGO DE DARLE REINCIAR, MOSTRAMOS EL frmLogin
                        tiempo = 30;
                        txtUsuario.Text = String.Empty; //  LIMPIAMOS LA CAJA DE TEXTO
                        txtContraseña.Text = String.Empty;
                        txtUsuario.Focus();
                

                        new FrmMDI(dt.Rows[0][0].ToString()).ShowDialog();

                        //FrmMDI mdi = new FrmMDI();
                        //mdi.ShowDialog();

                    }
                    else if (dt.Rows[0][1].ToString() == "Almacenero" || dt.Rows[0][1].ToString() == "Jefe Logistica" || dt.Rows[0][1].ToString() == "Operario")
                    {

                        this.Hide();
             

                        this.Visible = true; // LUEGO DE DARLE REINCIAR, MOSTRAMOS EL frmLogin
                        tiempo = 30;
                        txtUsuario.Text = String.Empty; //  LIMPIAMOS LA CAJA DE TEXTO
                        txtContraseña.Text = String.Empty;
                        txtUsuario.Focus();
                    



                        new FrmMDIU(dt.Rows[0][0].ToString()).ShowDialog();
                        //FrmMDIU mdi = new FrmMDIU();
                        //mdi.ShowDialog();

                    }


                }
                else
                {

                   MessageBox.Show("Usuario y/o Contraseña incorrecta");
                    intentos += 1;
                    if (intentos == 3)
                    {
                        // Application.Exit();
                        this.Close();
                    }
                }

            
            }
            catch (SqlException x)
            {
                blnexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // No olvidarse!!!!!!
                cmd.Parameters.Clear();
            }
            return blnexito;



        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Trim() != "" & txtContraseña.Text.Trim() != "")
            {

                Logear(txtUsuario.Text, txtContraseña.Text);
            
              
              
            }

            else
            {
                intentos += 1;
                MessageBox.Show("Usuario o Password obligatorios"+",  Nº De Intentos  "+intentos,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;  // DECREMENTA EL TIEMPO
            this.Text = "Ingrese su Login y password. Le quedan......." + tiempo; // MUESTRA EL TIEMPO QUE QUEDA
            if (tiempo == 0)
            {

                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();   
                Application.Exit();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
      
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btnAceptar.PerformClick();

            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btnAceptar.PerformClick();

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
