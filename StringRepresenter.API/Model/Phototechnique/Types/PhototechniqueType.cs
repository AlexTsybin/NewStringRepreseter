using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Phototechnique.Types
{
    public abstract class PhototechniqueType : OfferType
    {
        public PhototechniqueType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
