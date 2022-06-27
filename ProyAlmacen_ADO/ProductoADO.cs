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
    public class ProductoADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProducto";
            //Agregamos parametros 
            try
            {

                cmd.Parameters.AddWithValue("@vnom", objProductoBE.Nom_prod);
                cmd.Parameters.AddWithValue("@vdescripcion", objProductoBE.Descr_prod);
                cmd.Parameters.AddWithValue("@vmarca", objProductoBE.Marca_prod);
                cmd.Parameters.AddWithValue("@vmedida", objProductoBE.Medida_prod);
                cmd.Parameters.AddWithValue("@vprecioCompra", objProductoBE.PrecioCom_prod);
                cmd.Parameters.AddWithValue("@vstockMin", objProductoBE.StockMin_prod);
                cmd.Parameters.AddWithValue("@vcategoria", objProductoBE.Categoria_prod);
                cmd.Parameters.AddWithValue("@vproveedor", objProductoBE.Proveedor_prod);

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
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProducto";
            //Agregamos parametros 
            try
            {

                cmd.Parameters.AddWithValue("@vcod", objProductoBE.Cod_Prod);
                cmd.Parameters.AddWithValue("@vnom", objProductoBE.Nom_prod);
                cmd.Parameters.AddWithValue("@vdescripcion", objProductoBE.Descr_prod);
                cmd.Parameters.AddWithValue("@vmarca", objProductoBE.Marca_prod);
                cmd.Parameters.AddWithValue("@vmedida", objProductoBE.Medida_prod);
                cmd.Parameters.AddWithValue("@vprecioCompra", objProductoBE.PrecioCom_prod);
                cmd.Parameters.AddWithValue("@vstockMin", objProductoBE.StockMin_prod);
                cmd.Parameters.AddWithValue("@vstockAct", objProductoBE.StockAct_prod);
                cmd.Parameters.AddWithValue("@vcategoria", objProductoBE.Categoria_prod);
                cmd.Parameters.AddWithValue("@vproveedor", objProductoBE.Proveedor_prod);

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

        public Boolean EliminarProducto(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProducto";
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
                cmd.Parameters.Clear();
            }
            return blnexito;

        }

        public ProductoBE ConsultarProducto(string strcod)
        {
            ProductoBE objProductoBE = new ProductoBE();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";

                cmd.Parameters.AddWithValue("@vcod", strcod);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                    dtr.Read();
                {
                    if (dtr["id_Producto"] == DBNull.Value)
                    {
                        objProductoBE.Cod_Prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Cod_Prod = dtr["id_Producto"].ToString();
                    }

                    if (dtr["prod_nom"] == DBNull.Value)
                    {
                        objProductoBE.Nom_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Nom_prod = dtr["prod_nom"].ToString();
                    }

                    if (dtr["prod_descr"] == DBNull.Value)
                    {
                        objProductoBE.Descr_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Descr_prod = dtr["prod_descr"].ToString();
                    }

                    if (dtr["prod_marca"] == DBNull.Value)
                    {
                        objProductoBE.Marca_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Marca_prod = dtr["prod_marca"].ToString();
                    }

                    if (dtr["prod_unidMed"] == DBNull.Value)
                    {
                        objProductoBE.Medida_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Medida_prod = dtr["prod_unidMed"].ToString();
                    }

                    if (dtr["prod_PrecioCompra"] == DBNull.Value)
                    {
                        objProductoBE.PrecioCom_prod = 0;
                    }
                    else
                    {
                        objProductoBE.PrecioCom_prod = Convert.ToSingle(dtr["prod_PrecioCompra"]);
                    }

                    if (dtr["prod_stockMin"] == DBNull.Value)
                    {
                        objProductoBE.StockMin_prod = 0;
                    }
                    else
                    {
                        objProductoBE.StockMin_prod = Convert.ToInt32(dtr["prod_stockMin"]);
                    }


                    if (dtr["prod_stockAct"] == DBNull.Value)
                    {
                        objProductoBE.StockAct_prod = 0;
                    }
                    else
                    {
                        objProductoBE.StockAct_prod = Convert.ToInt32(dtr["prod_stockAct"]);
                    }



                    if (dtr["prod_estado"] == DBNull.Value)
                    {
                        objProductoBE.Estado_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Estado_prod = dtr["prod_estado"].ToString();
                    }

                    if (dtr["id_Categoria"] == DBNull.Value)
                    {
                        objProductoBE.Categoria_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Categoria_prod = dtr["id_Categoria"].ToString();
                    }

                    if (dtr["id_Proveedor"] == DBNull.Value)
                    {
                        objProductoBE.Proveedor_prod = String.Empty;
                    }
                    else
                    {
                        objProductoBE.Proveedor_prod = dtr["id_Proveedor"].ToString();
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
            return objProductoBE;
        }
        public DataTable ListarProducto()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Producto");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Producto"];
        }
        public DataTable ListarProductoActivo()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductoActivo";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "ProductoActivo");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["ProductoActivo"];
        }
        public DataTable ListarProductoInactivo()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductoInactivos";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "ProductoInactivos");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["ProductoInactivos"];
        }
        public DataTable ListarProductoProveedor(String strcod)
        {
            try
            {
                //album dodne se pega la foto
                DataSet dts = new DataSet();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductoProveedor";
                cmd.Parameters.AddWithValue("@vcodProv", strcod);

                //fotografo
                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ProductoProveedor");//Nombre de la tabla , el fotografo se encarga de abrir y cerrar la conexion ( Entorno desconectado)

                return dts.Tables["ProductoProveedor"];//return dts.Tables["ClientesDistrito"]

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }



        }
    }


    }

