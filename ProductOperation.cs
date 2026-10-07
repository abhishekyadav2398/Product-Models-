using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using productLinqAss.Model;
using produtLinqAss.Operation;

namespace productLinqAss.Services
{
    public class ProductOperation : IProductOperation
    {
        List<Product> products = new List<Product>();
        int IProductOperation.Add(Product product)
        {
            products.Add(product);
            return 1;
        }

        int IProductOperation.DeleteProducts(int id)
        {
            Product pro = products.Find(a => a.Id == id);
            products.Remove(pro);
            return 1;
        }

        Product IProductOperation.GetProductById(int id)
        {
            var pro = products.Find(a => a.Id == id);
            return (pro);
        }

        List<Product> IProductOperation.GetProducts()
        {
            return products;
        }

        List<Product> IProductOperation.SearchByPrice(int price)
        {
            List<Product> proPrice = products.Where(a => a.Price >= price).ToList();
            return proPrice;
        }

        Product IProductOperation.UpdateProducts(Product product, int id)
        {
            Product existingProduct = products.Find(e => e.Id == id);
            if (existingProduct.Id == product.Id)
                existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;
            return existingProduct;
        }
    }
}