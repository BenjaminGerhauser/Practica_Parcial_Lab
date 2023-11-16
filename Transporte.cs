using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;

namespace Practica_Parcial_Lab
{
    internal class Transporte
    {
        SQLiteCommand Comando;
        SQLiteConnection Conector;
        string sql;
        DataTable tabla;

        public Transporte()
        {
            Conector = new SQLiteConnection("Data Source=TRANSPORTE.db;");
            Comando = new SQLiteCommand();
            sql = "";
        }

        public int Buscar(int aa, int mm, int chofer) 
        {
            Combustible c = new Combustible();
            int litros;
            Conector.Open();

            sql = $"SELECT litros FROM Combustible WHERE aa={aa} AND mm={mm} AND chofer={chofer}";
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Read();
                litros = Convert.ToInt32(dr["litros"]);
                return litros;
            }
            Conector.Close();
            return 0;
        }

        public DataTable Choferes()
        {
            tabla = new DataTable();
            tabla.Columns.Add("chofer");
            tabla.Columns.Add("nombre");
            Conector.Open();
            sql = "SELECT * FROM Choferes";

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();
            
            foreach (var f in dr)
            {
                tabla.Rows.Add(dr["chofer"], dr["nombre"]);
            }
            Conector.Close();
            return tabla;
        }

        public void grabar(int aa, int mm, int chofer, int litros) 
        {
            Conector.Open();
            sql = $"INSERT INTO Combustible (aa, mm, chofer, litros) VALUES({aa}, {mm}, {chofer}, {litros})";

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            Comando.ExecuteNonQuery();
            Conector.Close();

        }
        public DataTable BuscarChofer(int chofer)
        {
            tabla = new DataTable();
            tabla.Columns.Add("aa");
            tabla.Columns.Add("mm");
            tabla.Columns.Add("litros");
            Conector.Open();

            sql = $"SELECT aa,mm,litros FROM Combustible WHERE chofer={chofer}";
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();
            foreach (var f in dr)
            {
                tabla.Rows.Add(dr["aa"], dr["mm"], dr["litros"]);
            }
            
            Conector.Close();
            return tabla;
        }
        public DataTable totalLitros()
        {
            tabla = new DataTable();
            tabla.Columns.Add("AA");
            tabla.Columns.Add("Litros");
            Conector.Open();

            sql = "SELECT aa, SUM(litros) AS litros FROM Combustible GROUP BY aa";
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();
            foreach (var f in dr)
            {
                tabla.Rows.Add(dr["aa"], dr["litros"]);
            }
            Conector.Close();
            return tabla;
        }
        public string Chofer(int chofer)
        {
            string nombre;
            Conector.Open();
            sql = $"SELECT nombre FROM Choferes WHERE chofer={chofer}";

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Read();
                nombre = dr["nombre"].ToString();
                dr.Close();
            }
            else
            {
                nombre = "";
            }
            Conector.Close();
            return nombre;

        }

        public void modificar(string nombre, int chofer)
        {
            Conector.Open();
            
            //sql = $"UPDATE Choferes SET nombre = '{nombre}' WHERE chofer={chofer}";

            //Comando.Connection = Conector;
            //Comando.CommandType = CommandType.Text;
            //Comando.CommandText = sql;


            //Conector.Update();
            //Comando.ExecuteNonQuery();

            var sqlUpdate = Conector.CreateCommand();
            sqlUpdate.CommandText = $@"
                                        UPDATE Choferes 
                                        SET nombre = '{nombre}' 
                                        WHERE chofer={chofer}
                                    ";

            // Bind the parameters to the query.
            sqlUpdate.Parameters.AddWithValue("$nombre", nombre);
            sqlUpdate.Parameters.AddWithValue("$chofer", chofer);
            sqlUpdate.ExecuteNonQuery();

            Conector.Close();

        }

        public DataTable totalLitros2()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Chofer");
            tabla.Columns.Add("AA");
            tabla.Columns.Add("Total litros");
            Conector.Open();

            sql = @"SELECT Combustible.chofer ,Combustible.aa, sum(Combustible.litros) AS litros
                    FROM Combustible 
                    GROUP BY Combustible.aa, Combustible.chofer";

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;

            SQLiteDataReader dr = Comando.ExecuteReader();
            foreach (var f in dr)
            {
                tabla.Rows.Add(dr["chofer"],dr["aa"], dr["litros"]);
            }
            dr.Close();
            Conector.Close();
            return tabla;
        }
    }
}
