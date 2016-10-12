using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model
{
    public class Currency
    {
        public string Id { get; set;}
        public double Rate { get; set; }
        public double Plus { get; set; }

        public Currency(string id, double rate, double plus)
        {
            Id = id;
            Rate = rate;
            Plus = plus;
        }
    }
}
