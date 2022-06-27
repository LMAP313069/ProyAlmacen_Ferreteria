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
    public class ProveedorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProveedor";
            //Agregamos parametros
            try
            {
                //Codifique


                cmd.Parameters.AddWithValue("@vraso", objProveedorBE.Raz_prov);
                cmd.Parameters.AddWithValue("@vdirec", objProveedorBE.Direc_prov);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prov);
                cmd.Parameters.AddWithValue("@vtelf", objProveedorBE.Telf_prov);
                cmd.Parameters.AddWithValue("@vcontac", objProveedorBE.Contac_prov);

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
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
            //Agregamos parametros 
            try
            {
                //Codifique

                cmd.Parameters.AddWithValue("@vcod", objProveedorBE.Cod_Prov);
                cmd.Parameters.AddWithValue("@vraso", objProveedorBE.Raz_prov);
                cmd.Parameters.AddWithValue("@vdirec", objProveedorBE.Direc_prov);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prov);
                cmd.Parameters.AddWithValue("@vtelf", objProveedorBE.Telf_prov);
                cmd.Parameters.AddWithValue("@vcontac", objProveedorBE.Contac_prov);

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

        public Boolean EliminarProveedor(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProveedor";
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

        public ProveedorBE ConsultarProveedor(string strcod)
        {
            ProveedorBE objProveedorBE = new ProveedorBE();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
                cmd.Parameters.AddWithValue("@vcod", strcod);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                    dtr.Read();
                {
                    if (dtr["id_Proveedor"] == DBNull.Value)
                    {
                        objProveedorBE.Cod_Prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Cod_Prov = dtr["id_Proveedor"].ToString();

                    }

                    if (dtr["razonSocial"] == DBNull.Value)
                    {
                        objProveedorBE.Raz_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Raz_prov = dtr["razonSocial"].ToString();

                    }

                    if (dtr["Direc_prov"] == DBNull.Value)
                    {
                        objProveedorBE.Direc_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Direc_prov = dtr["Direc_prov"].ToString();

                    }

                    if (dtr["Ruc_prov"] == DBNull.Value)
                    {
                        objProveedorBE.Ruc_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Ruc_prov = dtr["Ruc_prov"].ToString();


                    }

                    if (dtr["tef_prov"] == DBNull.Value)
                    {
                        objProveedorBE.Telf_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Telf_prov = dtr["tef_prov"].ToString();

                    }

                    if (dtr["Contac_prov"] == DBNull.Value)
                    {
                        objProveedorBE.Contac_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Contac_prov = dtr["Contac_prov"].ToString();

                    }

                    if (dtr["estado_prov"] == DBNull.Value)
                    {
                        objProveedorBE.Estado_prov = String.Empty;

                    }
                    else
                    {
                        objProveedorBE.Estado_prov = dtr["estado_prov"].ToString();

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
            return objProveedorBE;
        }
        public DataTable ListarProveedor()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Proveedor");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Proveedor"];
        }

        public DataTable ListarProveedoresActivos() 
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedoresActivos";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "ProveedoresActivos");


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["ProveedoresActivos"];


        }
        public DataTable ListarProveedoresInactivos()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedoresInactivos";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "ProveedoresInactivos");


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["ProveedoresInactivos"];


        }

        public DataTable ListarProveedorNombre()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedoresNombre";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "ProvedoresNombres");


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["ProvedoresNombres"];


        }
        
        
    }
}
