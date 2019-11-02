﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Pipedrive
{
    public class Filter
    {

        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("temporary_flag")]
        public string Temporary_flag { get; set; }

        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        [JsonProperty("add_time")]
        public DateTime AddTime { get; set; }

        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; set; }

        [JsonProperty("visible_to")]
        public long? visible_to { get; set; }

        [JsonProperty("custom_view_id")]
        public long? custom_view_id { get; set; }

        //[JsonProperty("conditions")]
        //public long? conditions { get; set; }
    }
}
