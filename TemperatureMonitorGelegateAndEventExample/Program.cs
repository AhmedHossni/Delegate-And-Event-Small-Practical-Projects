using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileMonitorGelegateAndEventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsTempMonitor tempMonitor = new clsTempMonitor();

            tempMonitor.tempCheckHander += TemperatureWorning;

            tempMonitor.CheckTempValue();
        }

        private static void TemperatureWorning(object sender, int tempValue)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{tempValue}°C Temperature is too high (program will stop in 2s)");
            Console.Beep(1000, 2000);
            Console.ForegroundColor = ConsoleColor.White;
            
            Environment.Exit(0);
        }
    }
}
