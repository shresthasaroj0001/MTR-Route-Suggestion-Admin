using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class RouteSearch
    {
        public int Id { get; set; }
        public int FromStationId { get; set; }
        public virtual Station FromStation { get; set; }
        public int ToStationId { get; set; }
        public virtual Station ToStation { get; set; }
        public DateTime DateSearched { get; set; }
    }
}
