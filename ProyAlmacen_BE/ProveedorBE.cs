using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAlmacen_BE
{
    public class ProveedorBE
    {
        private String mvarcod_prov;
        public String Cod_Prov
        {
            get { return mvarcod_prov; }
            set { mvarcod_prov = value; }
        }
        private String mvarraz_prov;
        public String Raz_prov
        {
            get { return mvarraz_prov; }
            set { mvarraz_prov = value; }
        }
        private String mvardirec_prov;
        public String Direc_prov
        {
            get { return mvardirec_prov; }
            set { mvardirec_prov = value; }
        }

        private String mvarruc_prov;
        public String Ruc_prov
        {
            get { return mvarruc_prov; }
            set { mvarruc_prov = value; }
        }

     
        private String mvartelf_prov;
        public String Telf_prov
        {
            get { return mvartelf_prov; }
            set { mvartelf_prov = value; }
        }

        private String mvarcontac_prov;
        public String Contac_prov
        {
            get { return mvarcontac_prov; }
            set { mvarcontac_prov = value; }
        }

        private String mvarestado_prov;
        public String Estado_prov
        {
            get { return mvarestado_prov; }
            set { mvarestado_prov = value; }
        }

    }
}
