using System.IO;
using Newtonsoft.Json;

namespace Pipedrive
{
    public class NewFilter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        // add conditions
    }
}
