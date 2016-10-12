namespace StringRepresenter.API.Model
{
    public abstract class OfferType
    {
        public string Name { get; set; }

        public OfferType(string nameOfType)
        {
            Name = nameOfType;
        }
    }
}
