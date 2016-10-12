using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Media.Kinds
{
    public class Music : KindOfMedia
    {
        public string Artist { get; set; }

        public Music(string artist)
        {
            Artist = artist;
        }
    }
}
