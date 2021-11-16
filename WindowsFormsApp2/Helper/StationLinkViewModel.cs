using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Helper
{
    class StationLinkViewModel
    {
        public string From { get; set; }
        public int FromId { get; set; }
        public string To { get; set; }
        public int ToId { get; set; }
        public float Fare { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
