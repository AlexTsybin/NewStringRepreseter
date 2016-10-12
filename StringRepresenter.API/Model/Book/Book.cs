namespace StringRepresenter.API.Model.Book
{
    public class Book : Offer
    {
        public bool Downloadable { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Series { get; set; }
        public OfferKind KindOfBook { get; set; }
    }
}
