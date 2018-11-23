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
    public partial class Clienteform : Form
    {
        private List<Cliente> Inventario = new List<Cliente>();
        private BindingSource conexiondatos = new BindingSource();
        public Clienteform()
        {
            InitializeComponent();
           conexiondatos.DataSource = ArchivoClientes.Obtener();
            this.dataGridView1.DataSource = conexiondatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevocliente = new Cliente();
            nuevocliente.Cedula = textBox3.Text;
            nuevocliente.Nombre = textBox2.Text;
            nuevocliente.Apellido = textBox4.Text;
            nuevocliente.Telefono = (int)numericUpDown1.Value;
            nuevocliente.Correo = textBox5.Text;

            conexiondatos.Add(nuevocliente);


            Inventario.Add(nuevocliente);
            ArchivoClientes.Guardar(nuevocliente);


            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            numericUpDown1.Value = 0;
            textBox5.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
