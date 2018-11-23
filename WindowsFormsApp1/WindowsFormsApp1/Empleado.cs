using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Empleado : Personacs
    {
        public string Codigo { get; set; }

        public override string ToString()
        {
            return $"{Codigo};{Cedula};{Nombre};{Apellido};{Telefono};{Correo}";
        }
    }
    
}
