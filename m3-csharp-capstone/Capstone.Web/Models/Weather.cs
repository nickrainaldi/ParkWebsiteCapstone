using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{

    public class Weather
    {





        public string ParkCode { get; set; }
        public string ParkName
        {
            get
            {
                if (ParkCode == "CVNP")
                {
                    return "Cuyahoga Valley National Park";
                }
                else if (ParkCode == "ENP")
                {
                    return "Everglades National Park";
                }
                else if (ParkCode == "GCNP")
                {
                    return "Grand Canyon National Park";
                }
                else if (ParkCode == "GNP")
                {
                    return "Glacier National Park";
                }
                else if (ParkCode == "GSMNP")
                {
                    return "Great Smoky Mountains National Park";
                }
                else if (ParkCode == "GTNP")
                {
                    return "Grand Teton National Park";
                }
                else if (ParkCode == "MRNP")
                {
                    return "Mount Ranier National Park";
                }
                else if (ParkCode == "RMNP")
                {
                    return "Rocky Mountain National Park";
                }
                else if (ParkCode == "YNP")
                {
                    return "Yellowstone National Park";
                }
                else if (ParkCode == "YNP2")
                {
                    return "Yosemite National Park";
                }
                else
                {
                    return "Park Name Not Found";
                }
            }
            set
            {
                ParkName = value;
            }
        }
        public int FiveDayForcastValue { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public string Forecast { get; set; }
        public string TempType { get; set; }

        public double ConvertTemp(int temp)
        {
            if (TempType == "C")
            {
                temp = (int)(Math.Round(((temp - 32)*(5.0 / 9.0)), 0));
            }
            return temp;
        }
    }
}