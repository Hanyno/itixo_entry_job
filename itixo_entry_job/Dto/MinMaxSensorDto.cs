using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class MinMaxSensorDto
    {
        [JsonProperty("@id")]
        public string? Id { get; set; }

        [JsonProperty("@min")]
        public string? Min { get; set; }

        [JsonProperty("@max")]
        public string? Max { get; set; }
    }
}
