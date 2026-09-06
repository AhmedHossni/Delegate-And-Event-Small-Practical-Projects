using System.Threading;
using System.Threading.Tasks;
namespace FileProgressEventAndDelegateExample
{
    public class clsFileDownloader
    {
        public delegate void ProgressValueHandler(object sender, int value, string fileName);

        public event ProgressValueHandler ProgressValue;

        public void DownloadFile(string fileName)
        {
            int Progress = 0;

            while (Progress <= 100)
            {
                ProgressValue?.Invoke(this, Progress, fileName);

                Task.Run(() => Thread.Sleep(300)).Wait();

                Progress += 10;

            }
        }
    }
}
