using NetMQ.Sockets;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using Newtonsoft.Json;
using EDRP.Models;
using EDRP.Journal.Models;
using EDRP.Outfitting.Models;
using EDRP.Commodity.Models;
using EDRP.Shipyard.Models;

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

                    var result = utf8.GetString(uncompressed).Remove(2,1);
                    var obj = JsonConvert.DeserializeObject<BaseDataModel<JournalMessage>>(result);
                    Console.WriteLine(obj.Message.StarSystem);
                    // var obj = JsonConvert.DeserializeObject<BasicJsonModel>(result);
                    // if (obj.schemaRef == "https://eddn.edcd.io/schemas/journal/1")
                    // {
                    //     var msg = JsonConvert.DeserializeObject<JournalMessage>(obj.message);
                    // }
                    // else if (obj.schemaRef == "https://eddn.edcd.io/schemas/outfitting/2")
                    // {
                    //     var msg = JsonConvert.DeserializeObject<OutfittingMessage>(obj.message);
                    // }
                    // else if (obj.schemaRef == "https://eddn.edcd.io/schemas/shipyard/2")
                    // {
                    //     var msg = JsonConvert.DeserializeObject<ShipyardMessage>(obj.message);
                    // }
                    // else if (obj.schemaRef == "https://eddn.edcd.io/schemas/commodity/3")
                    // {
                    //     var message = JsonConvert.DeserializeObject<CommodityMessage>(obj.message);
                    //     Console.WriteLine(message.systemName);
                    // }

                    // Console.WriteLine(result);
                }
            }
        }
    }
}