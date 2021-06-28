using Microsoft.Owin.Hosting;
using System.Threading;

namespace HelloNickConsole.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://*:80/";
            using (WebApp.Start<Startup>(url: baseAddress))
                Thread.Sleep(Timeout.Infinite);
        }
    }
}
