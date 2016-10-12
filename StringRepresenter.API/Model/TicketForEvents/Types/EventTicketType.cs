using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.TicketForEvents.Types
{
    public abstract class EventTicketType : OfferType
    {
        public EventTicketType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
