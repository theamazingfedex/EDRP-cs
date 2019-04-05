using NetMQ.Sockets;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using Newtonsoft.Json;

namespace EDRP.client
{
    class ClientExample
    {
        public ClientExample(string endpoint)
        {
            var utf8 = new UTF8Encoding();

            using (var client = new SubscriberSocket())
            {
                client.Options.ReceiveHighWatermark = 1000;
                client.Connect(endpoint);
                client.SubscribeToAnyTopic();
                while (true)
                {
                    var bytes = client.ReceiveFrameBytes();
                    var uncompressed = ZlibStream.UncompressBuffer(bytes);

                    var result = utf8.GetString(uncompressed);
                    // var obj = JsonConvert.DeserializeObject(result);

                    Console.WriteLine(result);
                }
            }
        }
    }
}