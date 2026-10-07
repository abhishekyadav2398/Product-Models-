using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productLinqAss.Model;
using productLinqAss.Services;
using produtLinqAss.Operation;

namespace productLinqAss.Ui
{
    public class Ui
    {
         public static void Main()
        {
           IProductOperation  operation=new ProductOperation();
            
            Product product1 = new  Product();
            product1.Id = 102;
           product1.Name = "Washing Machine";
            product1.Price = 23000;
            product1.Category="Electronic";

             Product product2 = new  Product();
            product2.Id = 103;
           product2.Name = "Mixy";
            product2.Price = 20000;
            product2.Category="Electronic";
           
           Product product3 = new  Product();
            product3.Id = 103;
           product3.Name = "Study Board";
            product3.Price = 25000;
            product3.Category="stationary";

            //Adding Products
            operation.Add(product1);
            Console.WriteLine("Product Added!!");
            operation.Add(product2);
            Console.WriteLine("Employee Added!!");
            operation.Add(product3);
            //Showing List
            Console.WriteLine("Showing Employees\n");
            List<Product> products1 = operation.GetProducts();
            foreach (Product pro in products1)
            {
                Console.WriteLine(pro.Id + " " + pro.Name + " " + pro.Price+" "+pro.Category);
            }
            Console.WriteLine();

             //Searching through id 
            Product productById = operation.GetProductById(104);
            if (productById == null)
            {
                Console.WriteLine("Record not found");
             }
             else
             {
                Console.WriteLine("Searched Product details are: \n" + productById.Name + " " + productById.Price);
            }

            Console.WriteLine();
            //Updating product
            Product updateProduct = new Product();
             updateProduct.Name = "Study Board";
             updateProduct.Price = 30000;

             Product newproduct = operation.UpdateProducts(updateProduct, 102);
     Console.WriteLine("Updated 101 details are: \n" + newproduct.Name + " " + newproduct.Price);

            int deleteResult = operation.DeleteProducts(103);

            if (deleteResult == 1)
            {
            Console.WriteLine("--- Product 103 (mixy) deleted successfully ---\n");
            }
            else
            {
               Console.WriteLine("--- product not found; nothing was deleted ---\n");
             }

            List<Product> proPrice = operation.SearchByPrice(23000);
            if (proPrice.Count()==0)
            { 
                Console.WriteLine("Record not found");
            }
            else
            {
                foreach (Product pro in proPrice)
                {
                    Console.WriteLine(pro.Name);
                }
            }

             
        } 
    }
}