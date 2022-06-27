using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyAlmacen_BE;

namespace ProyAlmacen_ADO
{
   public class EmpleadoADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarEmpleado";
            //Agregamos parametros 
            try
            {

                cmd.Parameters.AddWithValue("@vnom", objEmpleadoBE.Emp_Nom);
                cmd.Parameters.AddWithValue("@vapeP", objEmpleadoBE.Emp_ApeP);
                cmd.Parameters.AddWithValue("@vapeM", objEmpleadoBE.Emp_ApeM);
                cmd.Parameters.AddWithValue("@vtelf", objEmpleadoBE.Emp_Telef);
                cmd.Parameters.AddWithValue("@vdni", objEmpleadoBE.Emp_Dni);
                cmd.Parameters.AddWithValue("@vdirec", objEmpleadoBE.Emp_Direc);
                cmd.Parameters.AddWithValue("@vfechaNac", objEmpleadoBE.Emp_fechaNac);
                cmd.Parameters.AddWithValue("@vcargo", objEmpleadoBE.id_Cargo);

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
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarEmpleado";
            //Agregamos parametros 
            try
            {

                cmd.Parameters.AddWithValue("@vcod", objEmpleadoBE.id_Empleado);
                cmd.Parameters.AddWithValue("@vnom", objEmpleadoBE.Emp_Nom);
                cmd.Parameters.AddWithValue("@vapeP", objEmpleadoBE.Emp_ApeP);
                cmd.Parameters.AddWithValue("@vapeM", objEmpleadoBE.Emp_ApeM);
                cmd.Parameters.AddWithValue("@vtelf", objEmpleadoBE.Emp_Telef);
                cmd.Parameters.AddWithValue("@vdni", objEmpleadoBE.Emp_Dni);
                cmd.Parameters.AddWithValue("@vdirec", objEmpleadoBE.Emp_Direc);
                cmd.Parameters.AddWithValue("@vfechaNac", objEmpleadoBE.Emp_fechaNac);
                cmd.Parameters.AddWithValue("@vcargo", objEmpleadoBE.id_Cargo);





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

        public Boolean EliminarEmpleado(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarEmpleado";
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strcod);

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

        public EmpleadoBE ConsultarEmpleado(string strcod)
        {
            EmpleadoBE objEmpleadoBE = new EmpleadoBE();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";

                cmd.Parameters.AddWithValue("@vcod", strcod);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                    dtr.Read();
                {
                    if (dtr["id_Empleado"] == DBNull.Value)
                    {
                        objEmpleadoBE.id_Empleado = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.id_Empleado = dtr["id_Empleado"].ToString();
                    }

                    if (dtr["Emp_Nom"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_Nom = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_Nom = dtr["Emp_Nom"].ToString();
                    }

                    if (dtr["Emp_ApeP"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_ApeP = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_ApeP = dtr["Emp_ApeP"].ToString();
                    }

                    if (dtr["Emp_ApeM"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_ApeM = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_ApeM = dtr["Emp_ApeM"].ToString();
                    }

                    if (dtr["Emp_Telef"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_Telef = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_Telef = dtr["Emp_Telef"].ToString();
                    }

                    if (dtr["Emp_Dni"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_Dni = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_Dni = dtr["Emp_Dni"].ToString();
                    }

                    if (dtr["Emp_Direc"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_Direc = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_Direc = dtr["Emp_Direc"].ToString();
                    }


                    if (dtr["Emp_fechaNac"] == DBNull.Value)
                    {
                        objEmpleadoBE.Emp_fechaNac = DateTime.Today;
                    }
                    else
                    {
                        objEmpleadoBE.Emp_fechaNac = Convert.ToDateTime(dtr["Emp_fechaNac"]);
                    }

          

                    if (dtr["id_Cargo"] == DBNull.Value)
                    {
                        objEmpleadoBE.id_Cargo = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.id_Cargo = dtr["id_Cargo"].ToString();
                    }
                    if (dtr["contraseña"] == DBNull.Value)
                    {
                        objEmpleadoBE.contraseña = String.Empty;
                    }
                    else
                    {
                        objEmpleadoBE.contraseña = dtr["contraseña"].ToString();
                    }

                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return objEmpleadoBE;
        }
        public DataTable ListarEmpleado()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Empleado");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Empleado"];
        }
        public DataTable ListarEmpleadoActivo()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleadoActivo";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "EmpleadoActivo");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["EmpleadoActivo"];
        }
        public DataTable ListarEmpleadoInactivo()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleadoInactivos";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "EmpleadoInactivo");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["[EmpleadoInactivo]"];
        }
        public DataTable ListarEmpleadoConUsuario()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleadoConUsuario";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "EmpleadoConUsuario");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["EmpleadoConUsuario"];
        }
        public DataTable ListarEmpleadoSinUsuario()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleadoSinUsuario";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "EmpleadoSinUsuario");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["EmpleadoSinUsuario"];
        }

        public Boolean RegistrarUsuario(EmpleadoBE objEmpleadoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_RegistrarUsuario";
            //Agregamos parametros 
            try
            {

                cmd.Parameters.AddWithValue("@vcod", objEmpleadoBE.id_Empleado);
                cmd.Parameters.AddWithValue("@vcontraseña", objEmpleadoBE.contraseña);

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
        public Boolean EliminarUsuario(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarUsuario";
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strcod);

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

