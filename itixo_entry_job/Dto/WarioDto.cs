using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class WarioDto
    {
        [JsonProperty("@degree")]
        public string? Degree { get; set; }

        [JsonProperty("@pressure")]
        public string? Pressure { get; set; }

        [JsonProperty("@serial_number")]
        public string? SerialNumber { get; set; }

        [JsonProperty("@model")]
        public string? Model { get; set; }

        [JsonProperty("@firmware")]
        public string? Firmware { get; set; }

        [JsonProperty("@runtime")]
        public string? Runtime { get; set; }

        [JsonProperty("@freemem")]
        public string? Freemem { get; set; }

        [JsonProperty("@date")]
        public string? Date { get; set; }

        [JsonProperty("@time")]
        public string? Time { get; set; }

        [JsonProperty("@language")]
        public string? Language { get; set; }

        [JsonProperty("@pressure_type")]
        public string? PressureType { get; set; }

        [JsonProperty("@r")]
        public string? R { get; set; }

        [JsonProperty("@bip")]
        public string? Bip { get; set; }

        [JsonProperty("input")]
        public SensorGroupDto? Input { get; set; }

        [JsonProperty("output")]
        public SensorGroupDto? Output { get; set; }

        [JsonProperty("variable")]
        public VariableDto? Variable { get; set; }

        [JsonProperty("minmax")]
        public MinMaxDto? MinMax { get; set; }
    }
}
