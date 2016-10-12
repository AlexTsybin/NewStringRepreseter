using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringRepresenter.API.Model
{
    public abstract class OfferFactory
    {
        public abstract Offer Create(XElement xml);
        public abstract OfferKind GetOfferKindById(int id, XElement xml);
        public abstract OfferType GetType(string type, XElement xml);
    }
}
