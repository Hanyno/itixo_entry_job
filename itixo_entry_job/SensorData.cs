using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itixo_entry_job
{
    public class SensorData
    {
        [Key]
        public int Id { get; set; }

        public string? SensorId { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Place { get; set; }
        public string? Value { get; set; }
        public string? Min { get; set; }
        public string? Max { get; set; }

        public string? GroupType { get; set; }

        public int WarioId { get; set; }
        public Wario? Wario { get; set; }
    }
}
