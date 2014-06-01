using System;
using Nancy.Hosting.Self;


namespace GlimpseConsole
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://127.0.0.1:1234")))
            {
                host.Start();
                Console.WriteLine("Running on http://127.0.0.1:1234");
                Console.ReadLine();
            }
        }
    }
}
