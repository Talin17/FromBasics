using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace numeroRomanoFormDB
{
    public partial class ConvertirRomano : MenuStripRomano
    {
        SqlConnection conexion = new SqlConnection("server=(localdb)\\mssqllocaldb; database=numerosRomanos ; integrated security = true");

        string getUnidad(int unidad)
        {
            conexion.Open();
            string consulta = "Select * from Unidad where Valor = '" + unidad + "'AND Tipo = 'Unidad'";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string noRomano = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    noRomano = reader.GetString(1);

                }
            }
            else
            {
                noRomano = "";
            }
            reader.Close();
            conexion.Close();
            return noRomano;

        }
        string getDecena(int decena)
        {
            conexion.Open();
            string consulta = "Select * from Unidad where Valor = '" + decena + "'AND tipo = 'Decena'";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string noRomano = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    noRomano = reader.GetString(0);

                }
            }
            else
            {
                noRomano = "";
            }
            reader.Close();
            conexion.Close();
            return noRomano;

        }
        string getCentena(int centena)
        {
            conexion.Open();
            string consulta = "Select * from Unidad where Valor = '" + centena + "'AND Tipo = 'Centena'";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string noRomano = "";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    noRomano = reader.GetString(0);

                }
            }
            else
            {
                noRomano = "";
            }
            reader.Close();
            conexion.Close();
            return noRomano;

        }

        int unidad = 0;
        int decena = 0;
        int centena = 0;
        int numero = 0;
        public ConvertirRomano()
        {
            InitializeComponent();
        }

        public void Operacion()
        {

            numero = Convert.ToInt32(txtCantidad.Text);

            centena = (numero / 100) * 100;
            decena = numero - centena;
            unidad = numero - centena;
            centena = centena / 100;
            decena = decena / 10;
            unidad = unidad - decena * 10;

            Convert.ToString(centena);
            Convert.ToString(decena);
            Convert.ToString(unidad);
            txtRomano.Text = $"{getCentena(centena)}{getDecena(decena)}{getUnidad(unidad)}";

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            Operacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion();
        }
    }
}
