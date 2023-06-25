using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service_by_class_diagram
{
    internal class Movie : VideoContent
    {
        public int Duration { get; set; }

        public Movie(string name, string description, int duration) :base(name, description)
        {
            Duration = duration;
        }

        public override string getInfo()
        {
            return Name + ", " + Desctription + ", " + Duration + " min";
        }
    }
}
