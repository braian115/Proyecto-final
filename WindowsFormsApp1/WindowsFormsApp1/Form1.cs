﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productoform ventana = new Productoform();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleadoform ventana = new Empleadoform();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Clienteform ventana = new Clienteform();
            ventana.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacturaForm2 ventana = new FacturaForm2();
            ventana.ShowDialog();

        }
    }
}
