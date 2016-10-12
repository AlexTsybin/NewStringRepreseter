namespace StringRepresenter.API.Model.OfficeEquipment.Types
{
    public class VendorModelType : OfficeEquipmentType
    {
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public string Model { get; set; }

        public VendorModelType(string nameOfType, string vendor, string vendorCode, string model) : base(nameOfType)
        {
            Vendor = vendor;
            VendorCode = vendorCode;
            Model = model;
        }
    }
}
