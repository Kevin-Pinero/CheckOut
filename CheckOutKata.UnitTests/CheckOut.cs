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
            //return items.Sum(item => new ProductFactory().Create(item).Price);

            var factory = new ProductFactory();
            var total = 0;
            var productCount = new Dictionary<string, int>();
            
            var discounts = new Dictionary<string, Tuple<int, int>>();
            discounts.Add("A", new Tuple<int, int>(3, 20));
            discounts.Add("B", new Tuple<int, int>(2,15));

            foreach (var item in items)
            {
                var product = factory.Create(item);
                if (productCount.ContainsKey(product.ToString()))
                {
                    productCount[product.ToString()]++;
                }
                else
                {
                    productCount[product.ToString()] = 1;
                }

                total += product.Price;

                if (discounts.ContainsKey(product.ToString()) && discounts[product.ToString()].Item1 % productCount[product.ToString()] ==0)
                {

                    total -= discounts[product.ToString()].Item2;
                }
            }

            // apply discount
            //foreach (var keyValuePair in productCount)
            //{
            //    if (keyValuePair.Key.PromotionQuantity == keyValuePair.Value)
            //    {
            //        total -= keyValuePair.Key.Discount;
            //    }
            //}

            return total;
        }

        //public int GetPromotions(string items)
        //{
        //    var dicProducts = new Dictionary<Product, int>();
        //    var factoryproduct = new ProductFactory();
        //    foreach (var item in items)
        //    {
        //        var product = factoryproduct.Create(item);
        //        if (!dicProducts.ContainsKey(product))
        //        {
        //            dicProducts.Add(product, 1);
        //        }
        //        else
        //        {
        //            dicProducts[product]++;
        //        }     
        //    }


        //}

    }
}
