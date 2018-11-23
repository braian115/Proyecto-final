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
    public partial class Productoform : Form
    {
        private List<Producto> Inventario3 = new List<Producto>();
        private BindingSource conexiondatos3 = new BindingSource();
        public Productoform()
        {
            InitializeComponent();
            conexiondatos3.DataSource = ArchivosProductos.Obtener();
            this.dataGridView1.DataSource = conexiondatos3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto nuevoproducto = new Producto();
            nuevoproducto.Codigo = textBox1.Text;
            nuevoproducto.Nombreproducto = textBox2.Text;
            nuevoproducto.Cantidad = (int)numericUpDown1.Value;
            nuevoproducto.Precio = (int)numericUpDown2.Value;

            conexiondatos3.Add(nuevoproducto);


            Inventario3.Add(nuevoproducto);

            ArchivosProductos.Guardar(nuevoproducto);


            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
