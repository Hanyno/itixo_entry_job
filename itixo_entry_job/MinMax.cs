using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itixo_entry_job
{
    public class MinMax
    {
        [XmlElement("s")]
        public List<MinMaxSensor> Sensors { get; set; }

    }
}
