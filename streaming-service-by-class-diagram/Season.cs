using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service_by_class_diagram
{
    internal class Season
    {
        public int SerialNumber { get; set; }
        public List<Episode> EpisodeList { get; set; } = new List<Episode>();
    }
}
