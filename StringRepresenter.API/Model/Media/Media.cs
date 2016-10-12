using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

namespace StringRepresenter.API.Model.Media
{
    public class Media : Offer
    {
        public string Title { get; set; }
        public string Storage { get; set; }
        public int Year { get; set; }
        public OfferKind KindOfMedia { get; set; }

        public Media(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
		             CategoryId categoryId, string picture, bool? delivery, string description, string title, string storage, int year, OfferKind kindOfMedia) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery, description)
        {
            Title = title;
            Storage = storage;
            Year = year;
            KindOfMedia = kindOfMedia;
        }
    }
}
