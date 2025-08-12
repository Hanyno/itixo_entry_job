using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job.Dto
{
    public class MinMaxDto
    {
        [JsonProperty("s")]
        public List<MinMaxSensorDto>? Sensors { get; set; }
    }
}
