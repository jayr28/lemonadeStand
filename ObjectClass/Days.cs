using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Days
    {

        //public string Day;
        //public string weather;
        //public string temperature;

        public List<string> DayList;
        public List<Weather> WeatherList;

        public void Initialize()
        {
            //Init Day of the week list
            DayList = new List<string>();
            DayList.Add("Monday");
            DayList.Add("Tuesday");
            DayList.Add("Wednesday");
            DayList.Add("Thursday");
            DayList.Add("Friday");
            DayList.Add("Saturday");
            DayList.Add("Sunday");

            // init weather list
            WeatherList = new List<Weather>();
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                Weather weather = new Weather();
                
                weather.temperature = rnd.Next(50, 96);

                int forecastSwitch = rnd.Next(1, 5);
                switch (forecastSwitch)
                {
                    case 1:
                        weather.forecast = "Sunny";
                        break;
                    case 2:
                        weather.forecast = "Partly Cloudy";
                        break;
                    case 3:
                        weather.forecast = "Hazy";
                        break;
                    case 4:
                        weather.forecast = "Cloudy";
                        break;
                    case 5:
                        weather.forecast = "Rainy";
                        break;

                }

                WeatherList.Add(weather);
             }
        }
    }
}
