using System;

namespace WorkShopProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principle");
            double principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            double year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate");
            double Rate = Convert.ToInt32(Console.ReadLine());
            Payment payment = new Payment(principle,year,Rate);
            payment.Calculate();
        }
    }
}
