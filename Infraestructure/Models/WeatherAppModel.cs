using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class WeatherAppModel
    {
        public DateTime ConvertDateTime(long seconds)
        {

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;

        }

        public double CovertTem(double temperatura)
        {
            double temp = temperatura - 273.15;
            return temp;

        }
        public double ConvertSpeed(double speed)
        {
            double vdv = speed * 3.6;
            return vdv;
        }


    }
}
