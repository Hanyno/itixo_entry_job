using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class VariableDto
    {
        [JsonProperty("sunrise")]
        public string? Sunrise { get; set; }
        [JsonProperty("sunset")]
        public string? Sunset { get; set; }
        [JsonProperty("civstart")]
        public string? Civstart { get; set; }
        [JsonProperty("civend")]
        public string? Civend { get; set; }
        [JsonProperty("nautstart")]
        public string? Nautstart { get; set; }
        [JsonProperty("nautend")]
        public string? Nautend { get; set; }
        [JsonProperty("astrostart")]
        public string? Astrostart { get; set; }
        [JsonProperty("astroend")]
        public string? Astroend { get; set; }
        [JsonProperty("daylen")]
        public string? Daylen { get; set; }
        [JsonProperty("civlen")]
        public string? Civlen { get; set; }
        [JsonProperty("nautlen")]
        public string? Nautlen { get; set; }
        [JsonProperty("astrolen")]
        public string? Astrolen { get; set; }
        [JsonProperty("moonphase")]
        public string? Moonphase { get; set; }
        [JsonProperty("isday")]
        public string? Isday { get; set; }
        [JsonProperty("bio")]
        public string? Bio { get; set; }
        [JsonProperty("pressure_old")]
        public string? PressureOld { get; set; }
        [JsonProperty("temperature_avg")]
        public string? TemperatureAvg { get; set; }
        [JsonProperty("agl")]
        public string? Agl { get; set; }
        [JsonProperty("fog")]
        public string? Fog { get; set; }
        [JsonProperty("lsp")]
        public string? Lsp { get; set; }
    }
}
