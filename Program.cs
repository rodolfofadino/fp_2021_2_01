using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace fiapweb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                        .UseStartup<Statup>()
                        .Build();
        }
    }
}
