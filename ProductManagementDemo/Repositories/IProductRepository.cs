﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        List<Product> GetProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product p);
        void DeleteProduct(Product p);

    }
}
