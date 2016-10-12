using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Book.Types
{
    public class TextType : BookType
    {
        public int Volume { get; set; }
        public int Part { get; set; }
        public string Binding { get; set; }
        public int PageExtent { get; set; }

        public TextType(string nameOfType, int volume, int part, string binding, int pageExtent)
            : base(nameOfType)
        {
            Volume = volume;
            Part = part;
            Binding = binding;
            PageExtent = pageExtent;
        }
    }
}
