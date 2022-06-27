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
    public class CategoriaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;
        public Boolean InsertarCategoria(CategoriaBE objCategoriaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarCategoria";
            //Agregamos parametros
            try
            {

                cmd.Parameters.AddWithValue("@vnom", objCategoriaBE.Cat_nombre);

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
        public Boolean ActualizarCategoria(CategoriaBE objCategoriaBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarCategoria";
            //Agregamos parametros 
            try
            {
                //Codifique

                cmd.Parameters.AddWithValue("@vcod", objCategoriaBE.Cod_Cate);
                cmd.Parameters.AddWithValue("@vnom", objCategoriaBE.Cat_nombre);


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

        public Boolean EliminarCategoria(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarCategoria";
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

        public CategoriaBE ConsultarCategoria(string strcod)
        {
            CategoriaBE objCategoriaBE = new CategoriaBE();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCategoria";
                cmd.Parameters.AddWithValue("@vcod", strcod);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                    dtr.Read();
                {
                    if (dtr["id_Categoria"] == DBNull.Value)
                    {
                        objCategoriaBE.Cod_Cate = String.Empty;

                    }
                    else
                    {
                        objCategoriaBE.Cod_Cate = dtr["id_Categoria"].ToString();

                    }

                    if (dtr["cat_nombre"] == DBNull.Value)
                    {
                        objCategoriaBE.Cat_nombre = String.Empty;

                    }
                    else
                    {
                        objCategoriaBE.Cat_nombre = dtr["cat_nombre"].ToString();

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
            return objCategoriaBE;
        }
        public DataTable ListarCategoria()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCategoria";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Categorias");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Categorias"];
        }

        public DataTable ListarCategoriaNombre()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCategoriaNombre";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "CategoriasNombre");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["CategoriasNombre"];
        }



    }
}

