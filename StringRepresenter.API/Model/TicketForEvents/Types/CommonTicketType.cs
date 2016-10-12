using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.TicketForEvents.Types
{
    public class CommonTicketType : EventTicketType
    {
        public CommonTicketType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
