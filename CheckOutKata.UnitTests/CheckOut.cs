using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutKata.UnitTests
{
    public class CheckOut
    {


        public int GetTotal(string items)
        {
            return items.Sum(item => new ProductFactory().Create(item).Price);
        }

        public int GetPromotions(string items)
        {
            var dicProducts = new Dictionary<Product, int>();
            var factoryproduct = new ProductFactory();
            foreach (var item in items)
            {
                var product = factoryproduct.Create(item);
                if (!dicProducts.ContainsKey(product))
                {
                    dicProducts.Add(product, 1);
                }
                else
                {
                    dicProducts[product]++;
                }     
            }


        }
    }
}
