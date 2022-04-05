using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class WeatherAppModel
    {
        public DateTime ConvertDateTime(long milesimasSeg)
        {

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(milesimasSeg).ToLocalTime();
            return day;

        }
    }
}
