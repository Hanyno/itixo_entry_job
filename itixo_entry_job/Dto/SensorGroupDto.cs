using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class SensorGroupDto
    {
        [JsonProperty("sensor")]
        public List<SensorDataDto>? Sensors { get; set; }
    }
}
