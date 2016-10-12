using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using StringRepresenter.API.Model;
using StringRepresenter.API.Model.Book;
using StringRepresenter.API.Model.Media;
using StringRepresenter.API.Model.OfficeEquipment;
using StringRepresenter.API.Model.Phototechnique;
using StringRepresenter.API.Model.TicketForEvents;
using StringRepresenter.API.Model.Travel;

namespace StringRepresenter.API
{
	public static class XmlParser
	{
		private static OfferFactory mFactory;

		public static List<Offer> ParseOffers(this XDocument doc)
		{
			var xml = doc;

			var shops = from xElement in xml.Root.Descendants("shop")
						select xElement;
			
			List<Offer> offList = new List<Offer>();

			foreach (var shopXml in shops)
			{
				var Categories = shopXml.Element("categories").Elements();

				List<Category> catList = new List<Category>();

				foreach (var category in Categories)
				{
					catList.Add(new Category(Convert.ToInt32(category.Attribute("id").Value),
						(category.Attributes().SingleOrDefault(atr => atr.Name == "parentId") != null) ? Convert.ToInt32(category.Attribute("parentId").Value) : 0,
						category.Value));
				}

				var Offers = shopXml.Element("offers").Elements();


				foreach (var offer in Offers)
				{
					int categoryId = Convert.ToInt32(offer.Element("categoryId").Value);
					mFactory = setFactoryByCategoryId(categoryId, catList);
					Offer newOffer = mFactory.Create(offer);
					offList.Add(newOffer);
				}
			}

			return offList;
		}
 
		public static void ParseOfferPart(XElement xml, out int id, out int bid,
			out int? cbid, out bool isAvailable, out string url, out double price, out string currencyId,
		                                  out CategoryId categoryId, out string picture, out bool? delivery, out string description)
		{
			id = Convert.ToInt32(xml.Attribute("id").Value);
			bid = Convert.ToInt32(xml.Attribute("bid").Value);
			if (xml.Attributes().SingleOrDefault(atr => atr.Name == "cbid") != null)
			{
				cbid = Convert.ToInt32(xml.Attribute("cbid").Value);
			}
			else
			{
				cbid = null;
			}
			isAvailable = Convert.ToBoolean(xml.Attribute("available").Value);

			url = xml.Element("url").Value;
			price = Convert.ToDouble(xml.Element("price").Value);
			currencyId = xml.Element("currencyId").Value;
			categoryId = new CategoryId(xml.Element("categoryId").Value, xml.Element("categoryId").Attribute("type").Value);
			//picture = xml.Element("picture").Value;
			picture = "http://picfun.ru/wp-content/uploads/HTxyUcwXfw.jpg"; // TODO
			if (xml.Elements().SingleOrDefault(atr => atr.Name == "delivery") != null)
			{
				delivery = Convert.ToBoolean(xml.Element("delivery").Value);
			}
			else
			{
				delivery = null;
			}
			description = xml.Element("description").Value;
		}

		private static List<Shop> ParseShops(IEnumerable<XElement> xml)
		{
			List<Shop> listOfShops = new List<Shop>();
			foreach (var shopXml in xml)
			{
				string shopName = shopXml.Element("name").Value;

				string shopCompany = shopXml.Element("company").Value;

				string shopUrl = shopXml.Element("url").Value;

				var Currencies = shopXml.Element("currencies").Elements();

				List<Currency> curList = new List<Currency>();
				foreach (var currency in Currencies)
				{
					curList.Add(
						new Currency(currency.Attribute("id").Value, Convert.ToDouble(currency.Attribute("rate").Value),
						Convert.ToDouble(currency.Attribute("plus").Value)));
				}

				var Categories = shopXml.Element("categories").Elements();

				List<Category> catList = new List<Category>();
				foreach (var category in Categories)
				{
					catList.Add(new Category(Convert.ToInt32(category.Attribute("id").Value),
						(category.Attributes().SingleOrDefault(atr => atr.Name == "parentId") != null) ? Convert.ToInt32(category.Attribute("parentId").Value) : 0,
						category.Value));
				}

				double shopLocalDeliveryCost = Convert.ToDouble(shopXml.Element("local_delivery_cost").Value);

				var Offers = shopXml.Element("offers").Elements();

				List<Offer> offList = new List<Offer>();
				foreach (var offer in Offers)
				{
					int categoryId = Convert.ToInt32(offer.Element("categoryId").Value);
					mFactory = setFactoryByCategoryId(categoryId, catList);
					Offer newOffer = mFactory.Create(offer);
					offList.Add(newOffer);
				}

				listOfShops.Add(new Shop(shopName, shopCompany, shopUrl, curList, catList, shopLocalDeliveryCost, offList)); // Полученный объект
			}
			return listOfShops;
		}

		private static OfferFactory setFactoryByCategoryId(int id, List<Category> catList)
		{
			switch (getParentId(id, catList))
			{
				case 1:
					{
						return new OfficeEquipmentFactory();
					}
				case 2:
					{
						return new PhototechniqueFactory();
					}
				case 3:
					{
						return new BookFactory();
					}
				case 4:
					{
						return new MediaFactory();
					}
				case 5:
					{
						return new TravelFactory();
					}
				case 6:
					{
						return new TicketForEventsFactory();
					}
				default:
					return null;
			}
		}

		private static int getParentId(int id, List<Category> catList)
		{
			int parentId = id;
			Category cat = catList.Single(category => category.Id == id);
			if (cat.ParentId != null)
			{
				parentId = getParentId((int)cat.ParentId, catList);
			}
			return parentId;
		}


	}
}
