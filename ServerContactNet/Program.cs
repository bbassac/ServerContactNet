using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                    .UseUrls("http://*:5000")
                  .UseKestrel()
                  .UseStartup<Startup>()
                  .Build();

            host.Run();
        }
    }
}
