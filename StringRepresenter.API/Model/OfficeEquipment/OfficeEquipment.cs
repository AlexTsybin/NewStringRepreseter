using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

namespace StringRepresenter.API.Model.OfficeEquipment
{
    public class OfficeEquipment : Offer
    {
        public string TypePrefix { get; set; }
        public double LocalDeliveryCost { get; set; }
        public OfferKind KindOfOfficeEquipment { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool ManufacturerWarranty { get; set; }
		public string Vendor { get; set;}
		public string VendorCode { get; set;}
		public string Model { get; set; }

        public OfficeEquipment(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
		                       CategoryId categoryId, string picture, bool? delivery, string description, string typePrefix, double localDeliveryCost,
		                       string countryOfOrigin, bool manufacturerWarranty, string vendor, string vendorCode, string model, OfferKind kindOfOfficeEquipment) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery,description)
        {
            TypePrefix = typePrefix;
            LocalDeliveryCost = localDeliveryCost;
            KindOfOfficeEquipment = kindOfOfficeEquipment;
            CountryOfOrigin = countryOfOrigin;
            ManufacturerWarranty = manufacturerWarranty;
			Vendor = vendor;
			VendorCode = vendorCode;
			Model = model;
        }
    }
}
