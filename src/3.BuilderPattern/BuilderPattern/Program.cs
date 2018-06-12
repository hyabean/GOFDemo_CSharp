using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 网上争议很大

            Director director = new Director();

            Product product1 = director.getAProduct();
            product1.ShowProduct();

            Product product1 = director.getAProduct();
            product1.ShowProduct();

            Console.ReadKey();
        }
    }
}
