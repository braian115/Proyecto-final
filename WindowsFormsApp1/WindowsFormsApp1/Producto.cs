using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Producto
    {
        public string Codigo { get; set; }
        public string Nombreproducto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public override string ToString()
        {
            return $"{Codigo};{Nombreproducto};{Cantidad};{Precio}";
        }
    }
}
