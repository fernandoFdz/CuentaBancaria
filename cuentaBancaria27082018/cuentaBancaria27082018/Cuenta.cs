using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentaBancaria27082018
{
    class Cuenta
    {
        private string nombreUsuario;
        private float dinRet;
        private float dinero;
        private float dep;
        public event EventHandler cambio;
       
        public string nombre
        {
            get
            {
                return nombreUsuario;
            }
            set
            {
                nombreUsuario = value;
            }
           
        }
       
        public float ingRetiro
        {
            get
            {
                return dinRet;
            }
            set
            {
                dinRet = value; 
            }
        }

        public float ingSaldo
        {
            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }

        public float deposito
        {
            get
            {
                return dep;
            }
            set
            {
                dep = value;
            }
        }

        public void hacerRetiro(float dato)
        {
               if(dinRet>500)
            cambio(this, EventArgs.Empty);
            
        }
            
        public void ingresaDep(float ingresa)
        {
            dinero += dinero + ingresa;
        }
            

    }
}
