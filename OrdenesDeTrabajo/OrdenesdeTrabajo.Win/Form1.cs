using OrdenesDeTrabajo.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesdeTrabajo.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ProductoBL = new ProductosBL();
            var listadeProductos = ProductoBL.ObtenerProductos();
            foreach (var productos in listadeProductos)
            {
                MessageBox.Show(productos.Descripcion);
            }



        }
    }
}
