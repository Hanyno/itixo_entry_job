using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itixo_entry_job
{
    public class Variable
    {
        [XmlElement("sunrise")]
        public string Sunrise { get; set; }

        [XmlElement("sunset")]
        public string Sunset { get; set; }

        [XmlElement("civstart")]
        public string CivilStart { get; set; }

        [XmlElement("civend")]
        public string CivilEnd { get; set; }

        [XmlElement("nautstart")]
        public string NauticalStart { get; set; }

        [XmlElement("nautend")]
        public string NauticalEnd { get; set; }

        [XmlElement("astrostart")]
        public string AstroStart { get; set; }

        [XmlElement("astroend")]
        public string AstroEnd { get; set; }

        [XmlElement("daylen")]
        public string DayLength { get; set; }

        [XmlElement("civlen")]
        public string CivilLength { get; set; }

        [XmlElement("nautlen")]
        public string NauticalLength { get; set; }

        [XmlElement("astrolen")]
        public string AstroLength { get; set; }

        [XmlElement("moonphase")]
        public int MoonPhase { get; set; }

        [XmlElement("isday")]
        public int IsDay { get; set; }

        [XmlElement("bio")]
        public int Bio { get; set; }

        [XmlElement("pressure_old")]
        public double PressureOld { get; set; }

        [XmlElement("temperature_avg")]
        public double TemperatureAvg { get; set; }

        [XmlElement("agl")]
        public int AGL { get; set; }

        [XmlElement("fog")]
        public int Fog { get; set; }

        [XmlElement("lsp")]
        public int LSP { get; set; }
    }
}
