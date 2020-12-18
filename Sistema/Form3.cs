using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDesplegable
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            if (PanelBoton1.Visible == true)
            {
                PanelBoton1.Visible = false;
            }
            else
            {
                PanelBoton1.Visible = true;
            }

            btnBoton1.Location = new Point(7, 60);
            PanelBoton1.Location = new Point(7, 108);
            btnBoton2.Location = new Point(7, 209);
            PanelBoton2.Hide();
            if (PanelBoton1.Visible == false)
            {
                btnBoton1.Location=new Point(7, 60);
                btnBoton2.Location = new Point(7, 110);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBoton1.Location = new Point(7, 60);
            btnBoton2.Location = new Point(7, 110);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {
            if (PanelBoton2.Visible == true)
            {
                PanelBoton2.Visible = false;
            }
            else
            {
                PanelBoton2.Visible = true;
            }

            PanelBoton2.Location = new Point(7, 157);
            btnBoton1.Location = new Point(7, 60);
            btnBoton2.Location = new Point(7, 109);

            PanelBoton1.Hide();

            if (PanelBoton2.Visible == false)
            {
                btnBoton1.Location = new Point(7, 60);
                btnBoton2.Location = new Point(7, 110);
            }
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
