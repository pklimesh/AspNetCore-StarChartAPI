using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int ID;
        public string Name; [Required]
        public int? OrbotedObjectID;
        public List<CelestialObject> Satellites;
        public TimeSpan OrbitalPeriod;
    }
}
