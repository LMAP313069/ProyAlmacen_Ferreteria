using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyAlmacen_BE;
using ProyAlmacen_ADO;

namespace ProyAlmacen_BL
{
    public class CategoriaBL
    {
        CategoriaADO objCategoriaADO = new CategoriaADO();

        public Boolean InsertarCategoria(CategoriaBE objCategoriaBE)
        {
            return objCategoriaADO.InsertarCategoria(objCategoriaBE);
        }
        public Boolean ActualizarCategoria(CategoriaBE objCategoriaBE)
        {
            return objCategoriaADO.ActualizarCategoria(objCategoriaBE);
        }
        public Boolean EliminarCategoria(String strcod)
        {
            return objCategoriaADO.EliminarCategoria(strcod);
        }
        public CategoriaBE ConsultarCategoria(String strcod)
        {
            return objCategoriaADO.ConsultarCategoria(strcod);
        }
        public DataTable ListarCategoria()
        {
            return objCategoriaADO.ListarCategoria();
        }
        public DataTable ListarCategoriaNombre()
        {
            return objCategoriaADO.ListarCategoriaNombre();
        }
    }
}
