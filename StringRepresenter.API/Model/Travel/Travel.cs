using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

namespace StringRepresenter.API.Model.Travel
{
    public class Travel : Offer
    {
        public double LocalDeliveryCost { get; set; }
        public string WorldRegion { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public OfferKind KindOfTravel { get; set; }

        public Travel(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
		              CategoryId categoryId, string picture, bool? delivery, string description, double localDeliveryCost, string worldRegion,
            string country, string region, OfferKind kindOfTravel) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery, description)
        {
            LocalDeliveryCost = localDeliveryCost;
            WorldRegion = worldRegion;
            Country = country;
            Region = region;
            KindOfTravel = kindOfTravel;
        }
    }
}
