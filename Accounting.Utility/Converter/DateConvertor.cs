using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Converter
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();

            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");

        }

        public static DateTime ToMiladi(DateTime datetime)
        {
            return new DateTime(datetime.Year , datetime.Month , datetime.Day ,new System.Globalization.PersianCalendar());
        }

        //public static DateTime ToMiladi(DateTime miladiDate)
        //{
        //    PersianCalendar persianCalendar = new PersianCalendar();
        //    return new DateTime(persianCalendar.GetYear(miladiDate),
        //                        persianCalendar.GetMonth(miladiDate),
        //                        persianCalendar.GetDayOfMonth(miladiDate),
        //                        persianCalendar);
        //}
    }
}
