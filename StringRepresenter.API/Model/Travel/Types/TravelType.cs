using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Travel.Types
{
    public abstract class TravelType : OfferType
    {
        public TravelType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
