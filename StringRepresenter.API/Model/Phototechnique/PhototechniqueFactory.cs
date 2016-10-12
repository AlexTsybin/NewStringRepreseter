using System.Xml.Linq;
using StringRepresenter.API.Model.Phototechnique.Kinds;

namespace StringRepresenter.API.Model.Phototechnique
{
    class PhototechniqueFactory : OfferFactory
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
            OfferType type = GetType(xml.Attribute("type").Value, xml);
            return new Phototechnique()
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
				Description = description
			};
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            switch (id)
            {
                case 11:
                    return new Camera();
                case 12:
                    return new Lens();
                default:
                    return null;
            }
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                default:
                    return null;
            }
        }
    }
}
