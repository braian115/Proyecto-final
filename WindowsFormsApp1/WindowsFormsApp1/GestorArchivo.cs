using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class GestorArchivo
    {
        public const string RUTA = @"C:/Temporal/empleado.txt";
        public static bool Guardar(Empleado empleado)
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
            writer.WriteLine(empleado.ToString());
            writer.Flush();
            writer.Close();

            return true;

        }
        public static List<Empleado> Obtener()
        {
            List<Empleado> LosEmpleados = new List<Empleado>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Empleado nuevo = new Empleado
                {
                    Codigo = datos[0],
                    Cedula = datos[1],
                    Nombre = datos[2],
                    Apellido = datos[3],
                    Telefono = Convert.ToInt32(datos[4]),
                    Correo = datos[5],




                };
                LosEmpleados.Add(nuevo);

            }
            file.Close();
            return LosEmpleados;
        }


      
    }
}
    


