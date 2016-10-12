using System;
using System.Collections.Generic;
using System.Xml.Linq;
using StringRepresenter.API.Model.Travel.Kinds;
using StringRepresenter.API.Model.Travel.Types;

namespace StringRepresenter.API.Model.Travel
{
    class TravelFactory : OfferFactory
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
            string worldRegion = xml.Element("worldRegion").Value;
            string country = xml.Element("country").Value;
            string region = xml.Element("region").Value;
            OfferType type = GetType(xml.Attribute("type").Value, xml);
			OfferKind kind = GetOfferKindById(Convert.ToInt32(categoryId.Text), xml);
            return new Travel()
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
				LocalDeliveryCost = localDeliveryCost,
				WorldRegion = worldRegion,
				Country = country,
				Region = region,
				KindOfTravel = kind
			};
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            switch (id)
            {
                case 19:
                    {
                        var Dates = xml.Elements("dataTour");
                        List<DateTime> listOfDate = new List<DateTime>();
                        foreach (var date in Dates)
                        {
                            listOfDate.Add(DateTime.Parse(date.Value).Date);
                        }
                        return new Tour(Convert.ToInt32(xml.Element("days").Value), listOfDate, xml.Element("name").Value, xml.Element("hotel_stars").Value, xml.Element("room").Value,
                            xml.Element("meal").Value, xml.Element("included").Value, xml.Element("transport").Value);
                    }
                case 20:
                    return new Flight();
                default:
                    return null;
            }
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                case "tour":
                    {
                        return new CommonTourType(type);
                    }
                default:
                    return null;
            }
        }
    }
}
