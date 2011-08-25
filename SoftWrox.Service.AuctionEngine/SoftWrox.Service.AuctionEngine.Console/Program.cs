using System;

namespace SoftWrox.Service.AuctionEngine.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new AuctionRepositoryTest();
            tests.Execute();

            System.Console.ReadLine();
        }
    }
}
