using System;
using System.Xml.Linq;
using StringRepresenter.API.Model.Media.Kinds;
using StringRepresenter.API.Model.Media.Types;

namespace StringRepresenter.API.Model.Media
{
    class MediaFactory : OfferFactory
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
            string title = xml.Element("title").Value;
            string storage = xml.Element("media").Value;
            int year = Convert.ToInt32(xml.Element("year").Value);
			OfferKind kindOfMedia = GetOfferKindById(Convert.ToInt32(categoryId.Text), xml);
            OfferType offerType = GetType(xml.Attribute("type").Value, xml);
            return new Media()
				{
				Id = id,
				OfferType = offerType,
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
				Title = title,
				Storage = storage,
				Year = year,
				KindOfMedia = kindOfMedia
			};
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            switch (id)
            {
                case 17:
                    return new Music(xml.Element("artist").Value);
                case 18:
                    return new Video(xml.Element("starring").Value, xml.Element("director").Value, xml.Element("originalName").Value, 
                        xml.Element("country").Value);
                default:
                    return null;
            }
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                case "artist.title":
                    {
                        return new ArtistTitleType(type);
                    }
                default:
                    return null;
            }
        }
    }
}
