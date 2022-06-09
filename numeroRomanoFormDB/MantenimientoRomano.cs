using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeroRomanoFormDB
{
    public partial class MantenimientoRomano : Form
    {
        
        SqlConnection conexion = new SqlConnection("server=(localdb)\\mssqllocaldb; database=numerosRomanos ; integrated security = true");
      
        private void conectar()
        {
            conexion.Open();
        }
        private void desconectar()
        {
            conexion.Close();
        }

        private void read(string search = "")
        {
            conectar();
            string consulta = $"Select * from Unidad {search}";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["Unidades"].ToString(),
                    reader["Valor"].ToString(),
                    reader["Tipo"].ToString());
            }
            desconectar();

        }
        private void search()
        {
            read($"where Unidades like '%{txtBuscar.Text}%'");
        }
       
        public MantenimientoRomano()
        {
            InitializeComponent();
        }

        private void MantenimientoRomano_Load(object sender, EventArgs e)
        {

        }

        private void dataGridBtn_Click_1(object sender, EventArgs e)
        {
            read();
        }

        private void DataGridbtnClear_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtBuscar.Text = "";
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarRomano agregarRomano = new AgregarRomano();
            agregarRomano.Show();
        }
    }
}
