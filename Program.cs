using System;
using EDRP.client;

namespace EDRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpointBase = "tcp://eddn.edcd.io:9500";
            var apiClient = new ClientExample(endpointBase);
            Console.WriteLine("Hello World!");
        }
        // TODO: Cache results in SQLiteDB
        // TODO: Only hold onto the last 100 results (for cachebusting)
        // TODO:
    }
}
