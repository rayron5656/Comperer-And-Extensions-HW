using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperer_And_Extensions_HW
{
    class MeasCompareByCity : IComparer<MeasureDetails>
    {
        public int Compare(MeasureDetails x, MeasureDetails y)
        {
            return x.City.CompareTo(y.City);
        }
    }

    class MeasCompareByCityAndDate : IComparer<MeasureDetails>
    {
        public int Compare(MeasureDetails x, MeasureDetails y)
        {
            if (x.City.CompareTo(y.City) == 0)
            {
                return x.Date.CompareTo(y.Date);
            }
            else
            {
                return x.City.CompareTo(y.City);
            }
        }
    }

    class MeasCompareByCityAndTemp : IComparer<MeasureDetails>
    {
        public int Compare(MeasureDetails x, MeasureDetails y)
        {
            if (x.Temperature.CompareTo(y.Temperature) == 0)
            {
                return x.City.CompareTo(y.City);
            }
            else
            {
                return x.Temperature.CompareTo(y.Temperature) * -1;
            }
        }
    }

    class MeasCompareByHumidTempAndCity : IComparer<MeasureDetails>
    {
        public int Compare(MeasureDetails x, MeasureDetails y)
        {
            if (x.HumidityInPercent.CompareTo(y.HumidityInPercent) == 0)
            {
                if (x.Temperature.CompareTo(y.Temperature) == 0)
                {
                    return x.City.CompareTo(y.City);
                }
                else
                {
                    return x.Temperature.CompareTo(y.Temperature) * -1;
                }
            }
            else
            {
                return x.HumidityInPercent.CompareTo(y.HumidityInPercent) * -1;
            }
        }
    }

    class MeasureDetails : IComparable<MeasureDetails>
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public float Temperature { get; set; }
        public int HumidityInPercent { get; set; }
        static Random R = new Random();
        
        public MeasureDetails(string city)
        {
            City = city;
            Date = new DateTime(R.Next(1980,2020),R.Next(1,12),R.Next(1,28));
            Temperature = (float)(R.Next(24,40) + (R.Next(0,9) / 10)); 
            HumidityInPercent = R.Next(0,100);
        }

        public int CompareTo(MeasureDetails other)
        {
            return Date.CompareTo(other.Date);
        }
    }
}
