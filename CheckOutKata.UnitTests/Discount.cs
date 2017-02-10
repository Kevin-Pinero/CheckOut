using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutKata.UnitTests
{
    // ProductA -> (quantity, amount)
    // ProductB -> (quantity, amount)
    // ProductC -> (quantity, amount)
    // ProductD -> (quantity, amount)
    // ...

    public class Discount
    {
        private readonly int _amount;
        private readonly int _quantity;

        public Discount(int amount, int quantity)
        {
            _amount = amount;
            _quantity = quantity;
        }

        //public int Quantity { get; set; }

        //public int Amount { get; set; }

        //public int Amount(Product p, int count)
        //{
        //    return 0;
        //}

        // Product's count - Amount
    }
}
