using System;
using System.Threading;
using System.Net.Http;
using ServiceReference;

namespace Server
{
    public class AdapterLogic : IAdapter
    {
        private static readonly HttpClient Client = new();

        public bool CanSubtractLiquid()
        {
            Console.WriteLine();
            Console.WriteLine($"Forwarding CanSubtractLiquid() request from gRPC client to REST server");
            Console.WriteLine();

            var service = new PumpService("http://127.0.0.1:5000", new HttpClient());
            return service.CanSubtractLiquid();
        }

        public int SubtractLiquid(int amount)
        {
            Console.WriteLine();
            Console.WriteLine($"Forwarding SubtractLiquid() request from gRPC client to REST server");
            Console.WriteLine();

            var service = new PumpService("http://127.0.0.1:5000", new HttpClient());
            return service.SubtractLiquid(amount);
        }
    }
}