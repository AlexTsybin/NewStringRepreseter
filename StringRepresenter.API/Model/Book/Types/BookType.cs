using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Book.Types
{
    public abstract class BookType : OfferType
    {
        public BookType(string nameOfType) : base(nameOfType)
        {
        }
    }
}
