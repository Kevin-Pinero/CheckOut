namespace CheckOutKata.UnitTests
{
    public abstract class Product
    {
        public int Price { get; protected set; }
        //public int PromotionQuantity { get; set; }
        //public int Discount { get; set; }

        public Discount Discount { get; protected set; }
    }


    public class ProductA : Product
    {
        public ProductA()
        {
            Price = 50;
            //PromotionQuantity = 3;
            //Discount = 20;
        }

        public override string ToString()
        {
            return "A";
        }
    }

    public class ProductB : Product
    {
        public ProductB()
        {
            Price = 30;
            //PromotionQuantity = 2;
            //Discount = 15;
        }
        public override string ToString()
        {
            return "B";
        }
    }

    public class ProductC : Product
    {
        public ProductC()
        {
            Price = 20;
        }

        public override string ToString()
        {
            return "C";
        }
    }

    public class ProductD : Product
    {
        public ProductD()
        {
            Price = 15;
        }

        public override string ToString()
        {
            return "D";
        }
    }
}