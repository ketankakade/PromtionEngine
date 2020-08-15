using PromotionEngine.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Service
{
    /// <summary>
    /// Product Service class containing business logic
    /// </summary>
    public static class ProductService
    {
        /// <summary>
        /// Get total price for product
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public static int GetTotalPrice(List<Product> products)
        {
            int counterOfA = 0;
            int priceOfA = 50;
            int counterOfB = 0;
            int priceOfB = 30;
            int counterOfC = 0;
            int priceOfC = 20;
            int counterOfD = 0;
            int priceOfD = 15;
            try
            {

                foreach (Product product in products)
                {
                    switch (product.Id)
                    {
                        case "A":
                        case "a":
                            counterOfA += 1;
                            break;
                        case "B":
                        case "b":
                            counterOfB += 1;
                            break;
                        case "C":
                        case "c":
                            counterOfC += 1;
                            break;
                        case "D":
                        case "d":
                            counterOfD += 1;
                            break;
                    }
                }
                //Calculate total price of orders
                int totalPriceOfA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
                int totalPriceOfB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
                int totalPriceOfC = (counterOfC * priceOfC);
                int totalPriceOfD = (counterOfD * priceOfD);

                //add all order price and return back
                return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured in GetTotalPrice ", ex);
                return 0;
            }
        }
    }
}