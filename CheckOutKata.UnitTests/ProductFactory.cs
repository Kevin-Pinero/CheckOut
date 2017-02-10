using System;

namespace CheckOutKata.UnitTests
{
    public class ProductFactory
    {
        public Product Create(char item)
        {
            Product product;
            switch (item)
            {
                case 'A':
                    product = new ProductA();
                    break;
                case 'B':
                    product = new ProductB();
                    break;
                case 'C':
                    product = new ProductC();
                    break;
                case 'D':
                    product = new ProductD();
                    break;
                default:
                    throw new NotSupportedException();
            }
            return product;
        }
    }
}