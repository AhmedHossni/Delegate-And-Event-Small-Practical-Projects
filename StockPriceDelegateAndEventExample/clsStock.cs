using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockPriceDelegateAndEventExample
{
    public class clsStock
    {
        public delegate void StockPriceDelegate(StockPriceEventArgs eventArgs);
        public event StockPriceDelegate StockPriceHandler;
        private string _stockName { get; set; }

        public class StockPriceEventArgs : EventArgs
        {
            public StockPriceEventArgs(string stockName, decimal oldPrice, decimal currentPrice)
            {
                this.stockName = stockName;
                this.oldPrice = oldPrice;
                this.currentPrice = currentPrice;
            }

            public string stockName { get; }
            public decimal oldPrice { get; }
            public decimal currentPrice { get;}
        }

        public clsStock(string stockName)
        {
            _stockName = stockName;
        }

        public void ChangeStockPrice()
        {
            Random random = new Random();
            decimal stockPrice = (decimal)random.NextDouble() * 1000;
            
            while (true)
            {
                decimal priceRandomChangeValue = (decimal)random.NextDouble() * 1;

                if (random.NextDouble() > 0.5)
                    priceRandomChangeValue *= 1;
                else
                    priceRandomChangeValue *= -1;

                decimal oldPrice = stockPrice;

                stockPrice += priceRandomChangeValue;

                StockPriceEventArgs stockPriceEventArgs =
                    new StockPriceEventArgs(_stockName, oldPrice, stockPrice);

                StockPriceHandler?.Invoke(stockPriceEventArgs);

                Thread.Sleep(300);


            }

        }

    }
}
