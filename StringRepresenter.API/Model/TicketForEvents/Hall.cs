using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.TicketForEvents
{
    public class Hall
    {
        public string Plan { get; set; }
        public string Name { get; set; }

        public Hall(string plan, string name)
        {
            Plan = plan;
            Name = name;
        }
    }
}
