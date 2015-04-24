using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mission_Explorer_Desktop
{
    public class JSONClass
    {
        [JsonProperty("elr")]
        public string elr { get; set; }
        [JsonProperty("line")]
        public string line { get; set; }
        [JsonProperty ("elrfrom")]
        public string elrfrom {get;set;}
        [JsonProperty("elrto")]
        public string elrto {get;set;}
        [JsonProperty("routes")]
        public string routes {get;set;}
    }
}
