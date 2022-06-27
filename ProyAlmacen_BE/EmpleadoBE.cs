using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAlmacen_BE
{
    public class EmpleadoBE
    {


        private String mvarcod_id;
        public String id_Empleado
        {
            get { return mvarcod_id; }
            set { mvarcod_id = value; }
        }

        private string mvaremp_Nom;
        public String Emp_Nom
        {
            get { return mvaremp_Nom; }
            set { mvaremp_Nom = value; }
        }

        private String mvaremp_ApeP;
        public String Emp_ApeP
        {
            get { return mvaremp_ApeP; }
            set { mvaremp_ApeP = value; }
        }

        private String mvaremp_ApeM;
        public String Emp_ApeM
        {
            get { return mvaremp_ApeM; }
            set { mvaremp_ApeM = value; }
        }

        private String mvaremp_telf;
        public String Emp_Telef
        {
            get { return mvaremp_telf; }
            set { mvaremp_telf = value; }
        }

        private String mvaremp_Dni;
        public String Emp_Dni
        {
            get { return mvaremp_Dni; }
            set { mvaremp_Dni = value; }
        }

        private String mvaremp_Direc;
        public String Emp_Direc
        {
            get { return mvaremp_Direc; }
            set { mvaremp_Direc = value; }
        }

    

        private DateTime mvaremp_FechaNac;
        public DateTime Emp_fechaNac
        {
            get { return mvaremp_FechaNac; }
            set { mvaremp_FechaNac = value; }
        }

        private String mvarcontraseña;
        public String contraseña
        {
            get { return mvarcontraseña; }
            set { mvarcontraseña = value; }
        }



        private String mvaridcargo;
        public String id_Cargo
        {
            get { return mvaridcargo; }
            set { mvaridcargo = value; }
        }



    }
}
