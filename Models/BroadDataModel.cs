using System;
using System.Collections.Generic;

namespace EDRP.Models
{
    public class BaseDataModel<MessageType>
    {
        public string SchemaRef { get; set; }
        public Header Header { get; set; }
        public MessageType Message { get; set; }
    }

    public class Header
    {
        public DateTime gatewayTimestamp { get; set; }
        public string softwareName { get; set; }
        public string softwareVersion { get; set; }
        public string uploaderID { get; set; }
    }
}