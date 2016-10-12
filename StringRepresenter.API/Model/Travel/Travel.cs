namespace StringRepresenter.API.Model.Travel
{
    public class Travel : Offer
    {
        public double LocalDeliveryCost { get; set; }
        public string WorldRegion { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public OfferKind KindOfTravel { get; set; }
    }
}
