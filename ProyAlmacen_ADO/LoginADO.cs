using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyAlmacen_ADO
{
    public class LoginADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;



       public Boolean Logear(string usuario, string contra)
        {

           

              
                //Agregamos parametros 
                try
                {


                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDniContraseña";
                //Codifique
                cmd.Parameters.AddWithValue("@emp_dni", usuario);
                    cmd.Parameters.AddWithValue("@contra", contra);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    // this.Hide();
                    if (dt.Rows[0][2].ToString() == "Administrador")
                    {

                        

                    }
                    else if (dt.Rows[0][2].ToString() == "Almacenero")
                    {


                    }

                
                }else 
                {

                    throw new Exception("Usuario y/o Contraseña incorrecta");
                }


                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    blnexito = true;
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

    }
}
