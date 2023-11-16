using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica_Parcial_Lab
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            grbVideo.Controls.Clear();
            Xpcom.Initialize("Firefox64");
            GeckoWebBrowser br = new GeckoWebBrowser { Dock = DockStyle.Fill };
            grbVideo.Controls.Add(br);
            br.Navigate(txtAutor.Text);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            Videos v = new Videos();
            DataTable tabla = v.videos();
            grilla.DataSource = tabla;
            grilla.Columns[0].Width = 50;
            grilla.Columns[1].Width = 150;
            grilla.Columns[2].Width = 200;
            grilla.Columns[3].Width = 275;
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAutor.Text = grilla.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
