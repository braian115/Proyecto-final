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
    public partial class FacturaForm2 : Form
    {
        private List<Cliente> Inventario = new List<Cliente>();
        private BindingSource conexiondatos = new BindingSource();

        private List<Empleado> Inventario2 = new List<Empleado>();
        private BindingSource conexiondatos2 = new BindingSource();

        private List<Producto> Inventario3 = new List<Producto>();
        private BindingSource conexiondatos3 = new BindingSource();

        public FacturaForm2()
        {
            InitializeComponent();
            conexiondatos.DataSource = ArchivoClientes.Obtener();
            this.dataGridViewfactura.DataSource = conexiondatos;

            conexiondatos2.DataSource = GestorArchivo.Obtener();
            this.dataGridView1.DataSource = conexiondatos2;

            conexiondatos3.DataSource = ArchivosProductos.Obtener();
            this.dataGridView2.DataSource = conexiondatos3;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
