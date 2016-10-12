using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
