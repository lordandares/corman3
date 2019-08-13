using Microsoft.Owin.Hosting;
using System;

namespace Armoniasoft.Corman.Net.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainAddress = "http://localhost:9009/";

            using (WebApp.Start(url: domainAddress))
            {
                Console.WriteLine("Service Hosted " + domainAddress);
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}
