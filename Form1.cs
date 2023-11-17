using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Practica_Parcial_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empresita em = new empresita();
            //DataTable tabla = em.getData();
            DataTable tabla = em.getTabla();

            CboSector.DisplayMember = "Nombre";
            CboSector.ValueMember = "SectorID";
            CboSector.DataSource = tabla;
            CboSector.SelectedIndex = -1;
        }

        private void CboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresita em = new empresita();
            DataTable Empleados = em.Empleados(Convert.ToInt32(CboSector.SelectedValue));
            Grilla.DataSource = Empleados;
        }
    }
}
