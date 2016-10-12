using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

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

        public Book(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
            CategoryId categoryId, string picture, bool? delivery, string description, string name, string author, int year, string publisher, string isbn,
            string language, string series, bool downloadable, OfferKind kindOfBook) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery, description)
        {
            Downloadable = downloadable;
            ISBN = isbn;
            Year = year;
            Publisher = publisher;
            Name = name;
            Author = author;
            Language = language;
            Series = series;
            KindOfBook = kindOfBook;
        }
    }
}
