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
    public partial class Registrarproducto : Form
    {
        public Registrarproducto()
        {
            InitializeComponent();
            textBox4.Text = "Usuario: " + Session.usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = funciones2.insertar(textBox1.Text, textBox2.Text);
            MessageBox.Show(mensaje);
            dataGridView1.DataSource = funciones2.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funciones2.mostrar();
        }

        private void Registrarproducto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mensaje = funciones2.eliminar(Int32.Parse(textBox3.Text));
            MessageBox.Show(mensaje);
            dataGridView1.DataSource = funciones2.mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mensaje = funciones2.actualizar(Int32.Parse(textBox3.Text), textBox1.Text, textBox2.Text);
            MessageBox.Show(mensaje);

            dataGridView1.DataSource = funciones2.mostrar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
