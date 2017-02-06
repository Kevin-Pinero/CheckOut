namespace CheckOutKata.UnitTests
{
    public abstract class Product
    {
        public int Price { get; protected set; }
    }


    public class ProductA : Product
    {
        public ProductA()
        {
            Price = 50;
        }
    }

    public class ProductB : Product
    {
        public ProductB()
        {
            Price = 30;
        }
    }

    public class ProductC : Product
    {
        public ProductC()
        {
            Price = 20;
        }
    }

    public class ProductD : Product
    {
        public ProductD()
        {
            Price = 15;
        }
    }

}