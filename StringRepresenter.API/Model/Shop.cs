using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model
{
    public class Shop
    {
        public string Name { get; private set; }
        public string Company { get; private set; }
        public string Url { get; private set; }
        public List<Currency> Currencies { get; private set; }
        public List<Category> Categories { get; private set; }
        public double LocalDeliveryCost { get; private set; }
        public List<Offer> Offers { get; private set; }

        public Shop(string name, string company, string url, List<Currency> currencies, List<Category> categories, double localDeliveryCost, List<Offer> offers)
        {
            Name = name;
            Company = company;
            Url = url;
            Currencies = currencies;
            Categories = categories;
            LocalDeliveryCost = localDeliveryCost;
            Offers = offers;
        }
    }
}
