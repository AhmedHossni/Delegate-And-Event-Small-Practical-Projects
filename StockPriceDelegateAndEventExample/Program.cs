using System;

namespace StockPriceDelegateAndEventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            clsStock stock = new clsStock("Apple");

            stock.StockPriceHandler += Stock_StockPriceHandler;

            stock.ChangeStockPrice();
        }

        private static void Stock_StockPriceHandler(clsStock.StockPriceEventArgs eventArgs)
        {
            string stockInfo= $"{eventArgs.stockName} : {eventArgs.currentPrice:0.00}$";

            if(eventArgs.oldPrice > eventArgs.currentPrice)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stockInfo} (Price Down ↓)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stockInfo} (Price UP ↑)");
            }

        }
    }
}
