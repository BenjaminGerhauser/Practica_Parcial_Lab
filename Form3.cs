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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Transporte t = new Transporte();
            DataTable tabla = t.Choferes();
            cboChofer.ValueMember = "chofer";
            cboChofer.DisplayMember = "nombre";
            cboChofer.DataSource = tabla;
        }

        private void cboChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transporte t = new Transporte();
            DataTable tabla = t.BuscarChofer(Convert.ToInt32(cboChofer.SelectedValue));
            Grilla.DataSource = tabla;
        }
    }
}
