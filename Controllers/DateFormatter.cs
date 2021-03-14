using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BloggerCookBook.Controllers
{
    public class DateFormatter
    {
        private DateTime _originalDateTime;

        public DateFormatter(DateTime datetime)
        {
            _originalDateTime = datetime;
        }

        public DateTime DayBeginning()
        {
            return new DateTime(_originalDateTime.Year, _originalDateTime.Month, _originalDateTime.Day);
        }

        public DateTime DayEnding()
        {
            return this.DayBeginning().AddDays(1).AddMilliseconds(-1);
        }

        public DateTime WeekBeginning()
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var difference = _originalDateTime.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (difference < 0)
            {
                difference = difference + 7;
            }
            return _originalDateTime.AddDays(-difference).Date;
        }

        public DateTime WeekEnding()
        {
            return this.WeekBeginning().AddDays(7).AddMilliseconds(-1);
        }

        public DateTime MonthBeginning()
        {
            return new DateTime(_originalDateTime.Year, _originalDateTime.Month, 1);
        }

        public DateTime MonthEnding()
        {
            return this.MonthBeginning().AddMonths(1).AddMilliseconds(-1);
        }

        public override string ToString() 
        {
            return _originalDateTime.ToString("M-dd-yyyy", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
