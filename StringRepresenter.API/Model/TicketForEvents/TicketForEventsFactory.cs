using System;
using System.Xml.Linq;
using StringRepresenter.API.Model.TicketForEvents.Types;

namespace StringRepresenter.API.Model.TicketForEvents
{
    class TicketForEventsFactory : OfferFactory
    {
        public override Offer Create(XElement xml)
        {
            int id;
            int bid;
            int? cbid;
            bool isAvailable;
            string url;
            double price;
            string currencyId;
			CategoryId categoryId;
            string picture;
            bool? delivery;
            string description;
            XmlParser.ParseOfferPart(xml, out id, out bid, out cbid, out isAvailable, out url, out price, out currencyId, out categoryId,
                out picture, out delivery, out description);
            double localDeliveryCost = Convert.ToDouble(xml.Element("local_delivery_cost").Value);
            string name = xml.Element("name").Value;
            string place = xml.Element("place").Value;
            Hall hall = new Hall(xml.Element("hall").Attribute("plan").Value, xml.Element("hall").Value);
            string hallPart = xml.Element("hall_part").Value;
            DateTime date = Convert.ToDateTime(xml.Element("date").Value);
            bool isPremiere = Convert.ToByte(xml.Element("is_premiere").Value) == 0 ? false : true;
            bool isKids = Convert.ToByte(xml.Element("is_kids").Value) == 0 ? false : true; 
            OfferType type = GetType(xml.Attribute("type").Value, xml);
            return new TicketForEvents()
				{
				Id = id,
				OfferType = type,
				BId = bid,
				IsAvailable = isAvailable,
				CBId = cbid,
				Url = url,
				Price = price,
				CurrencyId = currencyId,
				CategoryId = categoryId,
				Picture = picture,
				Delivery = delivery,
				Description = description,
				Name = name,
				LocalDeliveryCost = localDeliveryCost,
				Place = place,
				Hall = hall,
				HallPart = hallPart,
				Date = date,
				IsPremiere = isPremiere,
				IsKids = isKids
			};
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            throw new NotImplementedException();
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                case "event-ticket":
                    {
                        return new CommonTicketType(type);
                    }
                default:
                    return null;
            }
        }
    }
}
