using pc.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc
{
    public partial class Form1 : Form
    {
        Computador comp = new Computador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comp.setOn_off(false);
            btnEncender.Enabled = true;
            btnApagar.Enabled = false;
            btnApp1.Enabled = false;
            btnApp2.Enabled = false;
            btnApp3.Enabled = false;
            btnApp4.Enabled = false;
            btnReiniciar.Enabled = false;
            txtGarantia.Enabled = false;
        }
        private void Encender()
        {
            comp.setOn_off(true);
            btnReiniciar.Enabled = true;
            btnApagar.Enabled = false;
            btnApp1.Enabled = true;
            btnApp2.Enabled = true;
            btnApp3.Enabled = true;
            btnApp4.Enabled = true;
            btnReiniciar.Enabled = true;
            comp.setFechaCompra(DateTime.Now);
        }
        private void Apagar()
        {
            comp.setOn_off(false);
            btnEncender.Enabled = true;
            btnApagar.Enabled = false;
            btnApp1.Enabled = false;
            btnApp2.Enabled = false;
            btnApp3.Enabled = false;
            btnApp4.Enabled = false;
            btnReiniciar.Enabled = false;
            txtGarantia.Text = "";
        }
        private void Reiniciar()
        {
            Apagar();
            Encender();
        }
        private void Fecha()
        {
            comp.setFechaCompra(DateTime.Now);
            comp.setGarantia(new DateTime(2024, 02, 28));
            DateTime fechaCompra = comp.getFechaCompra();
            DateTime garantia = comp.getFechaCompra();

            if (fechaCompra < garantia)
            {
                MessageBox.Show("La garantía está vigente.");
            }
            else if (fechaCompra == garantia)
            {
                MessageBox.Show("La garantía expira hoy.");
            }
            else
            {
                MessageBox.Show("La garantía ha expirado.");
            }
        }
        
        
        
        private void btnEncender_Click(object sender, EventArgs e)
        {
            Encender();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (comp.getOn_off() == true)
            {
                Reiniciar();
            }
            else
            {
                MessageBox.Show("Inicie el pc primero");
            }
        }

        private void btnApp1_Click(object sender, EventArgs e)
        {
            if (comp.getOn_off() == false)
            {
                MessageBox.Show("Inicie el pc primero");
            }
            else
            {
                MessageBox.Show(" Abriendo aplicacion de mensajeria...");
            }
        }

        private void btnApp2_Click(object sender, EventArgs e)
        {
            if (comp.getOn_off() == false)
            {
                MessageBox.Show("Inicie el pc primero");
            }
            else
            {
                MessageBox.Show(" Abriendo aplicacion de pedidos a domicilio...");
            }
        }

        private void btnApp3_Click(object sender, EventArgs e)
        {
            if (comp.getOn_off() == false)
            {
                MessageBox.Show("Inicie el pc primero");
            }
            else
            {
                MessageBox.Show(" Abriendo aplicacion de menu de videojuegos retro...");
            }
        }

        private void btnApp4_Click(object sender, EventArgs e)
        {
            if (comp.getOn_off() == false)
            {
                MessageBox.Show("Inicie el pc primero");
            }
            else
            {
                MessageBox.Show(" Abriendo el navegador...");
            }
        }
    }
}
