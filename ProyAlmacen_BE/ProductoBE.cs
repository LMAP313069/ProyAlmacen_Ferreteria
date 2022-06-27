using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAlmacen_BE
{
    public class ProductoBE
    {
        private String mvarcod_prod;
        public String Cod_Prod
        {
            get { return mvarcod_prod; }
            set { mvarcod_prod = value; }
        }
        private String mvarnom_prod;
        public String Nom_prod
        {
            get { return mvarnom_prod; }
            set { mvarnom_prod = value; }
        }

        private String mvardesc_prod;
        public String Descr_prod
        {
            get { return mvardesc_prod; }
            set { mvardesc_prod = value; }
        }

        private String mvarmarca_prod;
        public String Marca_prod
        {
            get { return mvarmarca_prod; }
            set { mvarmarca_prod = value; }
        }


        private String mvarmedida_prod;
        public String Medida_prod
        {
            get { return mvarmedida_prod; }
            set { mvarmedida_prod = value; }
        }

        private Single mvarprecioCom_prod;
        public Single PrecioCom_prod
        {
            get { return mvarprecioCom_prod; }
            set { mvarprecioCom_prod = value; }
        }

        private int mvarstockMin_prod;
        public int StockMin_prod
        {
            get { return mvarstockMin_prod; }
            set { mvarstockMin_prod = value; }
        }

        private int mvarstockAct_prod;
        public int StockAct_prod
        {
            get { return mvarstockAct_prod; }
            set { mvarstockAct_prod = value; }
        }

        private String mvarestado_prod;
        public String Estado_prod
        {
            get { return mvarestado_prod; }
            set { mvarestado_prod = value; }
        }
        private String mvarcateg_prod;
        public String Categoria_prod
        {
            get { return mvarcateg_prod; }
            set { mvarcateg_prod = value; }
        }
        private String mvarprove_prod;
        public String Proveedor_prod
        {
            get { return mvarprove_prod; }
            set { mvarprove_prod = value; }
        }

    }
}
