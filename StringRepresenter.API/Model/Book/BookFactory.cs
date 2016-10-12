using System;
using System.Linq;
using System.Xml.Linq;
using StringRepresenter.API.Model.Book.Kinds;
using StringRepresenter.API.Model.Book.Types;

namespace StringRepresenter.API.Model.Book
{
    class BookFactory : OfferFactory
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
			OfferKind kindOfBook = GetOfferKindById(Convert.ToInt32(categoryId.Text), xml);
            string name = xml.Element("name").Value;
            string author = xml.Element("author").Value;
            int year = Convert.ToInt32(xml.Element("year").Value);
            string publisher = xml.Element("publisher").Value;
            string isbn = xml.Element("ISBN").Value;
            string language = xml.Element("language").Value;
            string series;
            if (xml.Elements().SingleOrDefault(el => el.Name == "series") != null)
            {
                series = xml.Element("series").Value;
            }
            {
                series = null;
            }
            bool downloadable = Convert.ToBoolean(xml.Element("downloadable").Value);
            OfferType newType = GetType(xml.Attribute("type").Value, xml);
			return new Book()
			{
				Id = id,
				OfferType = newType,
				BId = bid,
				IsAvailable = isAvailable,
				CBId = cbid,
				Url = url,
				Price = price,
				CurrencyId = currencyId,
				CategoryId = categoryId,
				Picture = picture,
				Delivery = delivery,
				Description=description,
				Name=name,
				Author=author,
				Year=year,
				Publisher=publisher,
				ISBN=isbn,
				Language=language,
				Series=series,
				Downloadable=downloadable,
				KindOfBook=kindOfBook
			};
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            switch (id)
            {
                case 13:
                    return new Detective();
                case 14:
                    return new Fiction();
                case 15:
                    return new Guide();
                case 16:
                    return new ChildrensLiterature();
                default:
                    return null;
            }
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                case "book":
                    {
                        return new TextType(type, Convert.ToInt32(xml.Element("volume").Value), Convert.ToInt32(xml.Element("part").Value),
                            xml.Element("binding").Value, Convert.ToInt32(xml.Element("page_extent").Value));
                    }
                case "audiobook":
                    {
                        return new AudioType(type, xml.Element("performed_by").Value, xml.Element("performance_type").Value,
                            xml.Element("storage").Value, xml.Element("format").Value, xml.Element("recording_length").Value);
                    }
                default:
                    return null;
            }
        }
    }
}
