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
    public class ProductoBL
    {
        ProductoADO objProductoADO = new ProductoADO();

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.InsertarProducto(objProductoBE);
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.ActualizarProducto(objProductoBE);
        }
        public Boolean EliminarProducto(String strcod)
        {
            return objProductoADO.EliminarProducto(strcod);
        }
        public ProductoBE ConsultarProducto(String strcod)
        {
            return objProductoADO.ConsultarProducto(strcod);
        }
        public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }
        public DataTable ListarProductoProveedor(String strcod)
        {
            return objProductoADO.ListarProductoProveedor(strcod);
        }
        public DataTable ListarProductoActivo()
        {
            return objProductoADO.ListarProductoActivo();
        }
        public DataTable ListarProductoInactivo()
        {
            return objProductoADO.ListarProductoInactivo();
        }
    }
}
