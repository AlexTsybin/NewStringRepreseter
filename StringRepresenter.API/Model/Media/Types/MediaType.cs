using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Media.Types
{
    public abstract class MediaType : OfferType
    {
        public MediaType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
