using System.Runtime.CompilerServices;

namespace ExtentionLibrary1
{
    public static class StringExtention
    {
        public static int WordCount(this String str)
        {
            if (str == null)
            { 
                return 0;
            }
                var result = str.Split(new char[] { ',', ' ', '?' });
                return result.Length;
        }

        public static bool ToBool(this String str)
        {
            if (str != null)
            {
                return str.ToLower() == "true";
            }

            return false;
        }

        public static int GetDays (this DateTime dateTime, DateTime targetDate)
        {
            if (dateTime == DateTime.MinValue)
            {
                throw new ArgumentException("Data is not correct");
            }

            if (targetDate == DateTime.MinValue)
            {
                throw new ArgumentException("Date is not correct");
            }
            var startDate = dateTime;
            if (dateTime.Hour > 18) 
            {
            
            var starDate = startDate.AddDays(1);
            }
            return dateTime.GetDays(targetDate);
        }


    }
}