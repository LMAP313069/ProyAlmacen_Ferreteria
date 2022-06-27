using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProyAlmacen_ADO
{
   public class CargoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;



        public DataTable ListarCargo()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCargo";

                SqlDataAdapter ada; // el fotografo
                ada = new SqlDataAdapter(cmd);

                ada.Fill(dts, "Cargos");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Cargos"];
        }



    }
}
