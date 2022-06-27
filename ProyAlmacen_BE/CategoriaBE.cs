using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAlmacen_BE
{
    public class CategoriaBE
    {
        private String mvarcod_cate;
        public String Cod_Cate
        {
            get { return mvarcod_cate; }
            set { mvarcod_cate = value; }
        }
        private String mvarnom_cate;
        public String Cat_nombre
        {
            get { return mvarnom_cate; }
            set { mvarnom_cate = value; }
        }
      
    }
}
