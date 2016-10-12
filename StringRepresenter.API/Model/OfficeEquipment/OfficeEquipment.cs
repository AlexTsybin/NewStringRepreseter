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
    }
}
