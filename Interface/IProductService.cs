using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interface
{
    /// <summary>
    /// Product Service Interface 
    /// </summary>
    public interface IProductService
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }
}
