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
    public class ProveedorBL
    {
        ProveedorADO objProveedorADO = new ProveedorADO();

        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.InsertarProveedor(objProveedorBE);
        }
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.ActualizarProveedor(objProveedorBE);
        }
        public Boolean EliminarProveedor(String strcod)
        {
            return objProveedorADO.EliminarProveedor(strcod);
        }
        public ProveedorBE ConsultarProveedor(String strcod)
        {
            return objProveedorADO.ConsultarProveedor(strcod);
        }
        public DataTable ListarProveedor()
        {
            return objProveedorADO.ListarProveedor();
        }
        public DataTable ListarProveedoresActivos()
        {
            return objProveedorADO.ListarProveedoresActivos();
        }
        public DataTable ListarProveedoresInactivos()
        {
            return objProveedorADO.ListarProveedoresInactivos();
        }
        public DataTable ListarProveedorNombre()
        {
            return objProveedorADO.ListarProveedorNombre();
        }
        
    }
}
