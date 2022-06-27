using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProyAlmacen_ADO
{
    class ConexionADO
    {
        public string GetCnx()
        {
            string strCnx =
                ConfigurationManager.ConnectionStrings["almacen"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
