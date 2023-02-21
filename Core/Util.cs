using System;
using System.IO;

namespace com.venkat.framework.core
{

    public class Util
    {
        public static char FileSeparator
        {
            get
            {
                return Path.DirectorySeparatorChar;
            }
        }

        public static DateTime CurrentTime
        {
            get
            {
                DateTime Calendar = DateTime.Now;
                return Calendar;
            }
        }

        public static string GetCurrentFormattedTime(string DateFormatString)
        {
            DateTime Calendar = DateTime.Now;
            return string.Format("{0:" + DateFormatString + "}", Calendar);
        }

        public static string GetFormattedTime(DateTime Time, string DateFormatString)
        {
            return string.Format("{0:" + DateFormatString + "}", Time);
        }

        public static string GetTimeDifference(DateTime StartTime, DateTime EndTime)
        {
            long TimeDifference = EndTime.Ticks - StartTime.Ticks;
            TimeSpan ElapsedSpan = new TimeSpan(TimeDifference);
            return string.Format("{0}(Hours), {1}(Minutes), {2}(Seconds)", ElapsedSpan.Hours, ElapsedSpan.Minutes, ElapsedSpan.Seconds);
        }
    }

}
