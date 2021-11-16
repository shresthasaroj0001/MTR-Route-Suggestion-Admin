using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class StationLink
    {
        public int Id { get; set; }
        public int SubwayLine { get; set; }

        public float Fare { get; set; }

        public TimeSpan Duration { get; set; }

        public int FromStationId { get; set; }
        public virtual Station FromStation { get; set; }

        public int ToStationId { get; set; }
        public virtual Station ToStation { get; set; }
    }
}
