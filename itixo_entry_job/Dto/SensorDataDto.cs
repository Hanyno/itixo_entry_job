using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class SensorDataDto
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("place")]
        public string? Place { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
