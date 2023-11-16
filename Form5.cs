using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Parcial_Lab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Transporte t = new Transporte();
            string nombre = t.Chofer(int.Parse(txtChofer.Text));

            if (nombre == "")
            {
                MessageBox.Show("El chofer no existe");
            }
            else
            {
                txtNombre.Text = nombre;    
                    
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Transporte t = new Transporte();
            t.modificar(txtNombre.Text, int.Parse(txtChofer.Text));
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
