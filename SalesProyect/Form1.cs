using SalesProyect.Services;
using SalesProyect.ModelDb;

namespace SalesProyect
{
    public partial class Form1 : Form 
    {
        ProductService service = new ProductService();
      
        public Form1()
        {
            InitializeComponent();
            service.GetDataFromDb();
        }
        private void clear()
        {
            productTxt.Clear();
            codeTxt.Clear();
            quantityTxt.Clear();
            txtID.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetDataFromDb();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = productTxt.Text;
            product.Code = codeTxt.Text;
            product.Quantity = quantityTxt.Text;
            if (radioButton1.Checked == true)
            {
                product.IsAvailable = radioButton1.Checked;
            }
            else
            {
                product.IsAvailable = radioButton2.Checked;
            }
            service.AddProduct(product);
            clear();
            service.GetDataFromDb();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = Convert.ToInt32(txtID.Text);
            product.ProductName = productTxt.Text;
            product.Code = codeTxt.Text;
            product.Quantity = quantityTxt.Text;
            if (radioButton1.Checked == true)
            {
                product.IsAvailable = radioButton1.Checked;
            }
            else
            {
                product.IsAvailable = radioButton2.Checked;
            }
            service.EditProduct(product);
            clear();
            service.GetDataFromDb();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = Convert.ToInt32(txtID.Text);
            product.ProductName = productTxt.Text;
            product.Code = codeTxt.Text;
            product.Quantity = quantityTxt.Text;
            if (radioButton1.Checked == true)
            {
                product.IsAvailable = radioButton1.Checked;
            }
            else
            {
                product.IsAvailable = radioButton2.Checked;
            }
            service.DeleteProduct(product);
            clear();
            service.GetDataFromDb();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            productTxt.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            codeTxt.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            quantityTxt.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}