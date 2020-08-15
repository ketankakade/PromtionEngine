using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Service;
using PromotionEngine.Models;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();

                Console.WriteLine("Total Number of Order");
                int noOfOrder = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < noOfOrder; i++)
                {
                    Console.WriteLine("Please enter the type of product: A,B,C or D....");
                    string typeOfProduct = Console.ReadLine();
                    Product product = new Product(typeOfProduct);
                    products.Add(product);
                }

                int totalPrice = ProductService.GetTotalPrice(products);
                Console.WriteLine(totalPrice);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured", ex);
            }
        }     
    }
}
