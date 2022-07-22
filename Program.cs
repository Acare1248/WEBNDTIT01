using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace WebNDTIT01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //InsertData();
            //Printdata();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://10.0.0.51:5000");
                });
    
    /*private static void Printdata()
    {
        using (var context = new ComputerListContext())
        {
            var ComputerLists = context.ComputerList
            .Include(p => p.ComputerName);
            foreach(var ComputerList in ComputerLists)
            {
                var data = new StringBuilder();
                data.AppendLine($"Computer name: {ComputerList.ComputerName}");
                 Console.WriteLine(data.ToString());
            }
        }
    }*/
    
    }
}
