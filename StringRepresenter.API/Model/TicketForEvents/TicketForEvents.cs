using System;

namespace StringRepresenter.API.Model.TicketForEvents
{
    public class TicketForEvents : Offer
    {
        public double LocalDeliveryCost { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public Hall Hall { get; set; }
        public string HallPart { get; set; }
        public DateTime Date { get; set; }
        public bool IsPremiere { get; set; }
        public bool IsKids { get; set; }
    }
}
