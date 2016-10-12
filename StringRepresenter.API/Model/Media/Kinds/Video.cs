using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Media.Kinds
{
    public class Video : KindOfMedia
    {
        public string Starring { get; set; }
        public string Director { get; set; }
        public string OriginalName { get; set; }
        public string Country { get; set; }

        public Video(string starring, string director, string originalName, string country)
        {
            Starring = starring;
            Director = director;
            OriginalName = originalName;
            Country = country;
        }
    }
}
