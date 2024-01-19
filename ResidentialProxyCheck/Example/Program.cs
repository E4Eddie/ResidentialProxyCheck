using System;
using ResidentialProxyCheck;
namespace ConsoleApp1
{ 
    internal class Program
    {// example project
        static void Main(string[] args)
        {
            Console.Clear();
            ResidentialProxyChecker residentialProxyChecker = new ResidentialProxyChecker();

            Console.WriteLine("Type in a given proxy to check if its residential or not.");
            Console.Write("-->");
            string proxy = Console.ReadLine();

            try
            {
                if (residentialProxyChecker.IsResidentialProxy(proxy, 2000))
                { Console.WriteLine("That is a Residential Proxy"); }else
                { Console.WriteLine("That is NOT a Residential Proxy"); }} catch
                (Exception ex) { Console.WriteLine("Proxy failed, bad proxy."); 
            }

            Console.ReadKey();
            Main(args);
        }
    }
}
