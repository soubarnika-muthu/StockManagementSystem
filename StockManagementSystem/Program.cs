using System;

namespace StockManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stock Management system");
            StockPortfolio stock = new StockPortfolio();
            stock.ReadInput();
            Console.Read();
        }
    }
}
