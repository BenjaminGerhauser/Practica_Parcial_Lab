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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Transporte transporte = new Transporte();
            DataTable tabla = transporte.Choferes();
            cboChofer.DisplayMember = "nombre";
            cboChofer.ValueMember = "chofer";
            cboChofer.DataSource = tabla;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Combustible c = new Combustible();
            Transporte t = new Transporte();
            int aa = int.Parse(txtAño.Text);
            int mm = cboMes.SelectedIndex + 1;
            int chofer = Convert.ToInt32(cboChofer.SelectedValue);

            int litros = t.Buscar(aa,mm,chofer);
            if(litros == 0 ) 
            {
                MessageBox.Show("No existe");
            }
            else
            {
                txtLitros.Text = litros.ToString(); 

            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int aa = int.Parse(txtAño.Text);
            int mm = cboMes.SelectedIndex + 1;
            int chofer = Convert.ToInt32(cboChofer.SelectedValue);
            int litros = Convert.ToInt32(txtLitros.Text);
            Transporte t = new Transporte();
            t.grabar(aa, mm, chofer, litros);
        }
    }
}
