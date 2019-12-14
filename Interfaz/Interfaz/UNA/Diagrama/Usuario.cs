using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaz
{
    public class Cuenta
    {
        public Cuenta()
        {
        
        }

        ~Cuenta()
        {
        
        }

        private string Nombre
        {
            get;
            set;
        }

        private string Cedula
        {
            get;
            set;
        }

        private string Correo
        {
            get;
            set;
        }

        private string Direccion
        {
            get;
            set;
        }

        public int Contraseña
        {
            get;
            set;
            
        }
    }
}