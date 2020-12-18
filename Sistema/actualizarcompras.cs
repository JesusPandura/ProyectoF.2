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
    public partial class actualizarcompras : Form
    {
        public actualizarcompras()
        {
            InitializeComponent();
        }

        private void actualizarcompras_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = funciones3.actualizar(Int32.Parse(textBox9.Text), textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text);
            MessageBox.Show(mensaje);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
