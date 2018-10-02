using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Days
    {

        public List<Day> DayList;
      
        public void Initialize()
        {
            //Init Day of the week list
            DayList = new List<Day>();
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {

                Day day = new Day();
                switch (i)
                {
                    case 1: 
                        day.DOW = "Monday";
                        break;
                    case 2:
                        day.DOW = "Tuesday";
                        break;
                    case 3:
                        day.DOW = "Wednesday";
                        break;
                    case 4:
                        day.DOW = "Thursday";
                        break;
                    case 5:
                        day.DOW = "Friday";
                        break;
                    case 6:
                        day.DOW = "Saturday";
                        break;
                    case 7:
                        day.DOW = "Sunday";
                        break;
                }
         
                day.Temperature = rnd.Next(50, 96);
                int forecastSwitch = rnd.Next(1, 5);
                switch (forecastSwitch)
                {
                    case 1:
                        day.Forecast = "Sunny";
                        break;
                    case 2:
                        day.Forecast = "Partly Cloudy";
                        break;
                    case 3:
                        day.Forecast = "Hazy";
                        break;
                    case 4:
                        day.Forecast = "Cloudy";
                        break;
                    case 5:
                        day.Forecast = "Rainy";
                        break;

                }
                DayList.Add(day);
            }
            
        }
    }
}
