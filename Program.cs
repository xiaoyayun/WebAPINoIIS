using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPi
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:3344";
            using(WebApp.Start<Startup>(url))
            {
                Console.WriteLine("server start......");
                Console.ReadLine();
            }
        }
    }
}
