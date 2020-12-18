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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();

            textBox1.Text = "Usuario: "+ Session.usuario;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            this.productoTableAdapter.Fill(this.productosDataSet.producto);

        }

        private void ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.producto);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                

                textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox8.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                
              
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cantidad = textBox3.Text;
            string precio = textBox5.Text;
            

            double peka = Double.Parse(cantidad) * Double.Parse(precio);

           label4.Text = "El precio total es :"+ peka.ToString();

            label7.Text = "Su pago es: "+ textBox4.Text;

            double peki =  Double.Parse(textBox4.Text) - peka;
            label9.Text = "Su cambio es: " + peki.ToString();








            var mensaje = funciones3.comprar(Session.usuario, textBox2.Text,textBox8.Text,textBox5.Text,textBox3.Text,textBox4.Text,peka.ToString(),peki.ToString());
            MessageBox.Show(mensaje);


            


        }
    }
}
