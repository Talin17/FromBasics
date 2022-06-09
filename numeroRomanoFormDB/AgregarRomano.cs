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

    public partial class AgregarRomano : Form
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
        public AgregarRomano()
        {
            InitializeComponent();
            read();
        }
        private void read()
        {
            conectar();
            string read = "select * from Unidad";
            SqlCommand sqlCommand = new SqlCommand(read, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataGridAdd.Rows.Clear();
            while (reader.Read())
            {
                dataGridAdd.Rows.Add(
                    reader["Unidades"].ToString(),
                    reader["Valor"].ToString(),
                    reader["Tipo"].ToString(),
                    reader["ID"].ToString());
            }
            desconectar();
        }
        private void Add()
        {
            conectar();
            string add = $"insert into Unidad(Unidades,Valor,Tipo) values('{noRomanoTxt.Text}','{valorRom.SelectedItem}','{tipoRom.SelectedItem}')";
            SqlCommand sqlCommand = new SqlCommand(add, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataGridAdd.Rows.Clear();
            while (reader.Read())
            {
                dataGridAdd.Rows.Add(
                    reader["Unidades"].ToString(),
                    reader["Valor"].ToString(),
                    reader["Tipo"].ToString());
            }
            desconectar();
        }

        private void Update()
        {
            conectar();
            string update = $"update Unidad set Valor = '{valorRom.SelectedItem}',Tipo = '{tipoRom.SelectedItem}' WHERE ID = '{txtID.Text}'";
            SqlCommand sqlCommand = new SqlCommand(update, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataGridAdd.Rows.Clear();
            while (reader.Read())
            {
                dataGridAdd.Rows.Add(
                    reader["Unidades"].ToString(),
                    reader["Valor"].ToString(),
                    reader["Tipo"].ToString()
                    );
            }
            desconectar();
        }
        private void Delete()
        {
            conectar();
            string delete = $"Delete from Unidad where ID ='{txtID.Text}'";
            SqlCommand sqlCommand = new SqlCommand(delete, conexion);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataGridAdd.Rows.Clear();
            while (reader.Read())
            {
                dataGridAdd.Rows.Add(
                    reader["Unidades"].ToString(),
                    reader["Valor"].ToString(),
                    reader["Tipo"].ToString());
            }
            desconectar();
                    
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            MessageBox.Show("Agregado correctamente");
            noRomanoTxt.Text = "";
            read();
        }

        private void dataGridAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            noRomanoTxt.Text = this.dataGridAdd.CurrentRow.Cells[0].Value.ToString();
            valorRom.SelectedItem = this.dataGridAdd.CurrentRow.Cells[1].Value.ToString();
            tipoRom.SelectedItem = this.dataGridAdd.CurrentRow.Cells[2].Value.ToString();
            txtID.Text = this.dataGridAdd.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
            MessageBox.Show("Se actualizo el registro");
            noRomanoTxt.Text = "";
            txtID.Text = "";
            read();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("Se elimino el registro");
            noRomanoTxt.Text = "";
            txtID.Text = "";
            read();
        }
    }
}
