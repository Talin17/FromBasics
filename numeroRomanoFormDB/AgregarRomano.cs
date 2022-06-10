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
using numeroRomanoFormDB.ModelDB;

namespace numeroRomanoFormDB
{
    public partial class AgregarRomano : Form
    {

        public AgregarRomano()
        {

            InitializeComponent();
            Read();
        }



        private void Read()
        {

            var db = new numerosRomanosContext();
            var list = db.Unidads.ToList();
            dataGridAdd.DataSource = list;


        }
        private void Add()
        {
            var db = new numerosRomanosContext();
            Unidad addUnidad = new Unidad();
            addUnidad.Unidades = noRomanoTxt.Text;
            addUnidad.Valor = valorRom.Text;
            addUnidad.Tipo = tipoRom.Text;
            db.Unidads.Add(addUnidad);
            db.SaveChanges();
            Read();
        }

        private void Update()
        {
            var db = new numerosRomanosContext();
            int id = Convert.ToInt32(txtID.Text);
            var unidad = db.Unidads.First(m =>m.Id == id);
            unidad.Unidades = noRomanoTxt.Text;
            unidad.Valor = valorRom.Text;
            unidad.Tipo = tipoRom.Text;
            db.Unidads.Update(unidad);
            db.SaveChanges();
            Read();
        }
        private void Delete()
        {
            var db = new numerosRomanosContext();
            int id = Convert.ToInt32(txtID.Text);
            var unidad = db.Unidads.First(m => m.Id == id);
            db.Unidads.Remove(unidad);
            db.SaveChanges();
            Read();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            MessageBox.Show("Agregado correctamente");
            noRomanoTxt.Text = "";
            Read();
        }

        private void dataGridAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridAdd.CurrentRow.Cells[0].Value.ToString();
            noRomanoTxt.Text = this.dataGridAdd.CurrentRow.Cells[1].Value.ToString();
            valorRom.SelectedItem = this.dataGridAdd.CurrentRow.Cells[2].Value.ToString();
            tipoRom.SelectedItem = this.dataGridAdd.CurrentRow.Cells[3].Value.ToString();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
            MessageBox.Show("Se actualizo el registro");
            noRomanoTxt.Text = "";
            txtID.Text = "";
            Read();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("Se elimino el registro");
            noRomanoTxt.Text = "";
            txtID.Text = "";
            Read();
        }
    }
}
