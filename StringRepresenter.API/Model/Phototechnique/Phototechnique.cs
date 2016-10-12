using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringRepresenter.API;

namespace StringRepresenter.API.Model.Phototechnique
{
    public class Phototechnique : Offer
    {
        // TODO: Так как прототипа объекта не было найдено в XML, дополнительных полей не представленно.

        public Phototechnique(int id, OfferType type, int bid, bool isAvailable, int? cbid, string url, double price, string currencyId,
		                      CategoryId categoryId, string picture, bool? delivery, string description) 
            : base (id, type ,bid, cbid, isAvailable, url, price, currencyId, categoryId, picture, delivery, description)
        {
        }
    }
}
