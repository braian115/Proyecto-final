using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class ArchivoClientes
    {
        public const string RUTA = @"C:/Temporal/Cliente.txt";
        public static bool Guardar(Cliente cliente)
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
            writer.WriteLine(cliente.ToString());
            writer.Flush();
            writer.Close();

            return true;

        }
        public static List<Cliente> Obtener()
        {
            List<Cliente> LosClientes = new List<Cliente>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Cliente nuevo = new Cliente
                {
                    Cedula = datos[0],
                    Nombre = datos[1],
                    Apellido = datos[2],
                    Telefono = Convert.ToInt32(datos[3]),
                    Correo = datos[4]




                };
                 
                LosClientes.Add(nuevo);
               
            }
            file.Close();
            return LosClientes;
        }
    }
}
