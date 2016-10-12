using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

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

        public TicketForEvents(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
		                       CategoryId categoryId, string picture, bool? delivery, string description, double localDeliveryCost, string name, string place,
            Hall hall, string hallPart, DateTime date, bool isPremiere, bool isKids) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery, description)
        {
            LocalDeliveryCost = localDeliveryCost;
            Name = name;
            Place = place;
            Hall = hall;
            HallPart = hallPart;
            Date = date;
            IsPremiere = isPremiere;
            IsKids = isKids;
        }
    }
}
