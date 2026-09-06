using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileMonitorGelegateAndEventExample
{
    public class clsTempMonitor
    {
        public delegate void TempCheckHander(object sender, int tempValue);

        public event TempCheckHander tempCheckHander;

        public void CheckTempValue()
        {
            Random random = new Random();

            while (true)
            {
                Thread.Sleep(300);
                int currentTempValue = random.Next(1, 100);
                if (currentTempValue > 95)
                {
                    tempCheckHander?.Invoke(this, currentTempValue);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Current Temperature : {currentTempValue}°C");
                }
            }
        }
    }
}
