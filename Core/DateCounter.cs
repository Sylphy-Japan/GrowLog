using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowLog.Core
{
    public class DateCounter
    {
        public static int DaysSince(DateOnly from)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            return today.DayNumber - from.DayNumber;
        }
    }
}
