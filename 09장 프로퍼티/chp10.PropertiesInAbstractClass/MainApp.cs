using System;
using static System.Console;

namespace chp10.PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return $"{serial++:d5}"; }
        }
        //추상 프로퍼티
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 1, 10)
            };

            WriteLine($"Product : {product_1.SerialID}, Product Date : {product_1.ProductDate}");

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 2, 3)
            };

            WriteLine($"Product : {product_2.SerialID}, Product Date : {product_2.ProductDate}");
        }
    }
}
