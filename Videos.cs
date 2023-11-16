using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Practica_Parcial_Lab
{
    internal class Videos
    {
        SQLiteCommand comando;
        SQLiteConnection conector;
        DataTable tabla;
        string sql;
        public Videos()
        {
            comando = new SQLiteCommand();
            conector = new SQLiteConnection("Data Source=Miguel.db");
            sql = "";
        }

        public DataTable videos()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Tema");
            tabla.Columns.Add("Autor");
            tabla.Columns.Add("Link");
            conector.Open();
            sql = "SELECT * FROM VIdeos";
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
                
            SQLiteDataReader dr = comando.ExecuteReader();

            foreach (var f in dr)
            {
                tabla.Rows.Add(dr["Id"], dr["Tema"], dr["Autor"], dr["Link"]);
            }
            conector.Close();
            return tabla;
        }


    }
}
