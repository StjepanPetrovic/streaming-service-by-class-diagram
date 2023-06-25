using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service_by_class_diagram
{
    internal class Series : VideoContent
    {
        public List<Season> SeasonsList { get; set; }

        public Series(string name, string description) :base(name, description) {}

        public override string getInfo()
        {
            string info = "Series: " + Name + ", number of seasons: " + SeasonsList.Count() + "\n";

            foreach (var season in SeasonsList)
            {
                info += "Sezone: " + season.SerialNumber + ", number of episodes: " + season.EpisodeList.Count() + "\n";
            }

            return info;
        }
    }
}
