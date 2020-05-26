using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int ID { get; set; }
        public string Name { get; set; } [Required]
        public int? OrbotedObjectID { get; set; }
        public List<CelestialObject> Satellites { get; set; } [NotMapped]
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
