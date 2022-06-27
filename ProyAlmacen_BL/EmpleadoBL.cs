using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyAlmacen_BE;
using ProyAlmacen_ADO;
using System.Data;

namespace ProyAlmacen_BL
{
  public  class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();
        LoginADO objLoginADO = new LoginADO();
        CargoADO objCargoADO = new CargoADO();

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarEmpleado(String strcod)
        {
            return objEmpleadoADO.EliminarEmpleado(strcod);
        }
        public EmpleadoBE ConsultarEmpleado(String strcod)
        {
            return objEmpleadoADO.ConsultarEmpleado(strcod);
        }
        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }


        public DataTable ListarCargo()
        {
            return objCargoADO.ListarCargo();
        }
        public DataTable ListarEmpleadoActivo()
        {
            return objEmpleadoADO.ListarEmpleadoActivo();
        }

        public DataTable ListarEmpleadoInactivo()
        {
            return objEmpleadoADO.ListarEmpleadoInactivo();
        }
        public DataTable ListarEmpleadoConUsuario()
        {
            return objEmpleadoADO.ListarEmpleadoConUsuario();
        }
        public DataTable ListarEmpleadoSinUsuario()
        {
            return objEmpleadoADO.ListarEmpleadoSinUsuario();
        }

        public Boolean RegistrarUsuario(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.RegistrarUsuario(objEmpleadoBE);
        }
        public Boolean EliminarUsuario(String strcod)
        {
            return objEmpleadoADO.EliminarUsuario(strcod);
        }


        public Boolean Logear(String usuario, String  contra)
        {
            return objLoginADO.Logear(usuario, contra);
        }



    }
}
