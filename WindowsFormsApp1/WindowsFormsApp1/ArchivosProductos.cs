using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class ArchivosProductos
    {
        public const string RUTA = @"C:/Temporal/productos.txt";
        public static bool Guardar(Producto producto)
        {
            FileInfo archivo = new FileInfo(RUTA);
            if (archivo.Exists == false)
            {
                FileStream nuevoFs = archivo.Create();
                StreamWriter nuevoWriter = new StreamWriter(nuevoFs);
                nuevoWriter.Write("");
                nuevoWriter.Flush();
                nuevoWriter.Close();
                nuevoFs.Close();


            }

            StreamWriter writer = archivo.AppendText();
            writer.WriteLine(producto.ToString());
            writer.Flush();
            writer.Close();

            return true;

        }
        public static List<Producto> Obtener()
        {
            List<Producto> LosProductos = new List<Producto>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Producto nuevo = new Producto
                {
                    Codigo = datos[0],
                    Nombreproducto = datos[1],

                    Cantidad = Convert.ToInt32(datos[2]),
                    Precio = Convert.ToInt32(datos[3]),





                };
                LosProductos.Add(nuevo);

            }
            file.Close();   
            return LosProductos;
        }
    }
}
