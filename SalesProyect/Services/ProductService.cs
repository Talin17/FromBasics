using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProyect.ModelDb;


namespace SalesProyect.Services
{

    internal class ProductService
    {

        public Product GetElementById(int id)
        {
            var db = new SalesDbContext();
            var registro = db.Products.First(m => m.ProductId == id);
            return registro;
        }

        public List<Product> GetDataFromDb()
        {
            var db = new SalesDbContext();
            return db.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            var db = new SalesDbContext();
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public Product EditProduct(Product product)
        {
            var db = new SalesDbContext();
            var editProduct = product;
            editProduct.ProductName = product.ProductName;
            editProduct.Code = product.Code;
            editProduct.Quantity = product.Quantity;
            editProduct.IsAvailable = product.IsAvailable;
            db.Products.Update(editProduct);
            db.SaveChanges();
            return editProduct;
            
        }
        public Product DeleteProduct(Product product)
        {
            var db = new SalesDbContext();
            var deleteProduct = product;
            deleteProduct.ProductName = product.ProductName;
            deleteProduct.Code = product.Code;
            deleteProduct.Quantity = product.Quantity;
            deleteProduct.IsAvailable = product.IsAvailable;
            db.Products.Remove(deleteProduct);
            db.SaveChanges();
            return deleteProduct;
        }

    }
}
