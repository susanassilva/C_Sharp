

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace composition.Entities
{
    class HourContract : Worker
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; } 
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        
    }
}
