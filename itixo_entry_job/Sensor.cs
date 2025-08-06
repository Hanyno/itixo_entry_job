using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itixo_entry_job
{
    public class Sensor
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("place")]
        public string Place { get; set; }

        [XmlElement("value")]
        public string Value { get; set; }
    }
}
