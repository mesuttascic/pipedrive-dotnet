using System.IO;
using Newtonsoft.Json;

namespace Pipedrive
{
    public class FilterUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        // add conditions
    }
}
