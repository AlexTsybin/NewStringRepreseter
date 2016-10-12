namespace StringRepresenter.API.Model.Media
{
    public class Media : Offer
    {
        public string Title { get; set; }
        public string Storage { get; set; }
        public int Year { get; set; }
        public OfferKind KindOfMedia { get; set; }
    }
}
