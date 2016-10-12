using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StringRepresenter.API;
using StringRepresenter.API.Model.OfficeEquipment.Kinds.Printer.Kinds;
using StringRepresenter.API.Model.OfficeEquipment.Types;

namespace StringRepresenter.API.Model.OfficeEquipment
{
    class OfficeEquipmentFactory : OfferFactory
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
            string typePrefix = xml.Element("typePrefix").Value;
            double localDeliveryCost = Convert.ToDouble(xml.Element("local_delivery_cost").Value);
            string countryOfOrigin = xml.Element("country_of_origin").Value;
            bool manufacturerWarranty = Convert.ToBoolean(xml.Element("manufacturer_warranty").Value);
			string vendor = xml.Element("vendor").Value;
			string vendorCode = xml.Element("vendorCode").Value;
			string model = xml.Element("model").Value;
            OfferType type = GetType(xml.Attribute("type").Value, xml);
			OfferKind kind = GetOfferKindById(Convert.ToInt32(categoryId.Text), xml);
            return new OfficeEquipment(id, type, bid, isAvailable, cbid, url, price, currencyId, categoryId, picture, delivery,
			                           description, typePrefix, localDeliveryCost, countryOfOrigin, manufacturerWarranty,vendor,vendorCode,model, kind);
        }

        public override OfferKind GetOfferKindById(int id, XElement xml)
        {
            switch (id)
            {
                case 100:
                    return new JetPrinter();
                case 101:
                    return new LaserPrinter();
                default:
                    return null;
            }
        }

        public override OfferType GetType(string type, XElement xml)
        {
            switch (type)
            {
                case "vendor.model":
                    {
                        return new VendorModelType(type, xml.Element("vendor").Value, xml.Element("vendorCode").Value,
                            xml.Element("model").Value);
                    }
                default:
                    return null;
            }
        }
    }
}
