using System;

namespace StockManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stock Management system");
            Stock stock = new Stock();
            stock.ReadInpu();
            Console.Read();
        }
    }
}
