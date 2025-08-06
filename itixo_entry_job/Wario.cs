using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itixo_entry_job
{
    [XmlRoot("wario")]
    public class Wario
    {
        [XmlAttribute("degree")]
        public string Degree { get; set; }

        [XmlAttribute("pressure")]
        public string PressureUnit { get; set; }

        [XmlAttribute("serial_number")]
        public string SerialNumber { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("firmware")]
        public string Firmware { get; set; }

        [XmlAttribute("runtime")]
        public int Runtime { get; set; }

        [XmlAttribute("freemem")]
        public int FreeMem { get; set; }

        [XmlAttribute("date")]
        public string Date { get; set; }

        [XmlAttribute("time")]
        public string Time { get; set; }

        [XmlAttribute("language")]
        public int Language { get; set; }

        [XmlAttribute("pressure_type")]
        public int PressureType { get; set; }

        [XmlAttribute("r")]
        public int R { get; set; }

        [XmlAttribute("bip")]
        public int Bip { get; set; }

        [XmlElement("input")]
        public SensorGroup Input { get; set; }

        [XmlElement("output")]
        public SensorGroup Output { get; set; }

        [XmlElement("variable")]
        public Variable Variable { get; set; }

        [XmlElement("minmax")]
        public MinMax MinMax { get; set; }
    }
}
