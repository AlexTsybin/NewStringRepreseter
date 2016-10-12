using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

namespace StringRepresenter.API.Model
{
    public abstract class Offer
    {
        public int Id { get; set; }
        public OfferType Type { get; set; }
        public int BId { get; set; }
        public int? CBId { get; set; }
        public bool IsAvailable { get; set; }

        public string Url { get; set; }
        public double Price { get; set; }
        public string CurrencyId { get; set; }
		public CategoryId CategoryId { get; set;}
        public string Picture { get; set; }
        public bool? Delivery { get; set; }
        public string Description { get; set; }

        public Offer(int id, OfferType type, int bid, int? cbid, bool isAvailable, string url, double price, string currencyId,
		             CategoryId categoryId, string picture, bool? delivery, string description)
        {
            Id = id;
            Type = type;
            BId = bid;
            CBId = cbid;
            IsAvailable = isAvailable;
            Url = url;
            Price = price;
            CurrencyId = currencyId;
            CategoryId = categoryId;
            Picture = picture;
            Delivery = delivery;
            Description = description;
        }
        
    }
}
