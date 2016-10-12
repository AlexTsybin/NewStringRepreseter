using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepresenter.API.Model.Travel.Kinds
{
    public class Tour : KindOfTravel
    {
        public int AmountOfDays { get; set; }
        public List<DateTime> DataTour { get; set; }
        public string Name { get; set; }
        public string HotelStars { get; set; }
        public string RoomType { get; set; }
        public string Meal { get; set; }
        public string Included { get; set; }
        public string Transport { get; set; }

        public Tour(int amountOfDays, List<DateTime> dataTour, string name, string hotelStars, string roomType, string meal, string included, string transport)
        {
            AmountOfDays = amountOfDays;
            DataTour = dataTour;
            Name = name;
            HotelStars = hotelStars;
            RoomType = roomType;
            Meal = meal;
            Included = included;
            Transport = transport;
        }
    }
}
