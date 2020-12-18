using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();

            textBox4.Text = "Usuario: " + Session.usuario;
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizarcompras a = new actualizarcompras();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var mensaje = funciones3.eliminar(Int32.Parse(textBox1.Text));
            MessageBox.Show(mensaje);
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);

        }
    }
}
