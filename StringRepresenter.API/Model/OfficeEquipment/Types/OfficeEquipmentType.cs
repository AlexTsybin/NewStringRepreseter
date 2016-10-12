using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.OfficeEquipment.Types
{
    public abstract class OfficeEquipmentType : OfferType
    {
        public OfficeEquipmentType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
