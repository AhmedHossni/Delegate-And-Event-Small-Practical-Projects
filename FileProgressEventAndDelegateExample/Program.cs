using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProgressEventAndDelegateExample
{
    internal class Program
    {         
        static void Main(string[] args)
        {
            clsFileDownloader fileDownloader = new clsFileDownloader();

            fileDownloader.ProgressValue += ChangeProgressValue;

            fileDownloader.DownloadFile("My File");

        }

        public static void ChangeProgressValue(object sender, int value, string fileName)
        {
            Console.Clear();
            Console.WriteLine($"{fileName} : {value}%");
        }
        
    }
}
