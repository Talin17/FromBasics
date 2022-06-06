using System.Data.SqlClient;
namespace numeroRomanoFormDB
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=(localdb)\\mssqllocaldb; database=numerosRomanos ; integrated security = true");
        
        public void probarConexion()
        {
            conexion.Open();
            MessageBox.Show("Se establecio la conexion");
        }
        string getUnidad(int unidad)
        {
           
            string consulta = "Select * from Unidad where Valor = '" + unidad + "'";
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
            return noRomano;
            
        }
        string getDecena(int decena)
        {
            
            string consulta = "Select * from Decena where Valor = '" + decena + "'";
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
            return noRomano;
            
        }
        string getCentena(int centena)
        {
            
            string consulta = "Select * from Centena where Valor = '" + centena + "'";
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
            return noRomano;
            
        }

        int unidad = 0;
        int decena = 0;
        int centena = 0;
        int numero = 0;
        public Form1()
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

        private void dbButton_Click(object sender, EventArgs e)
        {
            probarConexion();

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Operacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Conexion cerrada");
        }
    }
}