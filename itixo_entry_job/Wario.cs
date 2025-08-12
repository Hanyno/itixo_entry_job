using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job
{
    public class Wario
    {
        [Key]
        public int Id { get; set; }

        public string? SerialNumber { get; set; }
        public string? Model { get; set; }
        public string? Firmware { get; set; }
        public string? Degree { get; set; }
        public string? Pressure { get; set; }
        public string? R { get; set; }
        public string? Bip { get; set; }
        public string? Language { get; set; }
        public string? PressureType { get; set; }
        public string? Runtime { get; set; }
        public string? Freemem { get; set; }

        public DateTime DownloadedAt { get; set; }
        public Status Status { get; set; }

        public List<SensorData>? Sensors { get; set; } = new List<SensorData>();

        public Variable? Variable { get; set; }
    }
}
