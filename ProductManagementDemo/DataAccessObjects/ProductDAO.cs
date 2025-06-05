using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        private static List<Product> listProduct;

        public ProductDAO()
        {
            Product chai = new Product
            {
                ProductId = 1,
                ProductName = "Chai",
                CategoryId = 1,
                UnitsInStock = 39,
                UnitPrice = 18.00m
            };
            Product chang = new Product
            {
                ProductId = 2,
                ProductName = "Chang",
                CategoryId = 1,
                UnitsInStock = 17,
                UnitPrice = 19.00m
            };
            Product aniseed = new Product
            {
                ProductId = 3,
                ProductName = "Aniseed Syrup",
                CategoryId = 2,
                UnitsInStock = 13,
                UnitPrice = 10.00m
            };
            listProduct = new List<Product>
            {
                chai,
                chang,
                aniseed
            };
        }

        public List<Product> GetProducts()
        {
            return listProduct;
        }

        public static List<Product> GetProducts()
        {
            var listProduct = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProduct = db.Products.toList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetProducts: " + ex.Message);
            }
            return listProduct;
        }


        public void SaveProduct(Product p)
        {
            listProduct.Add(p);
        }


        public void UpdateProduct(Product p)
        {
            foreach (var product in listProduct.ToList())
            {
                if (product.ProductId == p.ProductId)
                {
                    product.ProductName = p.ProductName;
                    product.CategoryId = p.CategoryId;
                    product.UnitsInStock = p.UnitsInStock;
                    product.UnitPrice = p.UnitPrice;
                    break;
                }
            }
        }


        public void DeleteProduct(int productId)
        {
            foreach (var product in listProduct.ToList())
            {
                if (product.ProductId == productId)
                {
                    listProduct.Remove(product);
                    break;
                }
            }
        }

        public Product GetProductById(int productId)
        {
            foreach (var product in listProduct.ToList())
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null; // or throw an exception if preferred
        }
    }
}
