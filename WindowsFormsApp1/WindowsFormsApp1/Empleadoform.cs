using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Empleadoform : Form
    {
        private List<Empleado> Inventario2 = new List<Empleado>();
        private BindingSource conexiondatos2 = new BindingSource();

        public Empleadoform()
        {
            InitializeComponent();
            conexiondatos2.DataSource = GestorArchivo.Obtener();
            this.dataGridView1.DataSource = conexiondatos2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado nuevoempleado = new Empleado();
            nuevoempleado.Codigo = textBox1.Text;
            nuevoempleado.Cedula = textBox3.Text;
            nuevoempleado.Nombre = textBox2.Text;
            nuevoempleado.Apellido = textBox4.Text;
            nuevoempleado.Telefono = (int)numericUpDown1.Value;
            nuevoempleado.Correo = textBox5.Text;

            conexiondatos2.Add(nuevoempleado);
            
        
            Inventario2.Add(nuevoempleado);
            GestorArchivo.Guardar(nuevoempleado);



            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
