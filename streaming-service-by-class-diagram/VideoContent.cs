using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service_by_class_diagram
{
    internal abstract class VideoContent
    {
        public string Name { get; set; }
        public string Desctription { get; set; }
        public ContentType Type { get; set; }

        public VideoContent(string name, string desctription)
        {
            Name = name;
            Desctription = desctription;
        }

        public abstract string getInfo();
    }
}
