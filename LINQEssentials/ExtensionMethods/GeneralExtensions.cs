namespace ExtensionMethods
{
    public static class GeneralExtensions
    {
        public static string ToTitle(this string value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();

            }
            string result = string.Join(" ", words);
            return result;

        }

        public static double GetSquare(this int value) => Math.Pow(value, 2);

        public static double GetSpesificPower(this int value, int power) => Math.Pow(value, power);

        public static int TotalWorkDays(this DateTime value, params DateTime[] holidays)
        {
            var startDate = new DateTime(value.Year, 1, 1);
            var endDate = new DateTime(value.Year, 12, 31);
            int totalDays = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (!i.IsWeekend() && !holidays.Contains(i))
                {
                    totalDays++;
                }
            }
            return totalDays;
        }

        public static bool IsWeekend(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;

        public static char NextChar(this Random value, bool isLower = true)
        {
            return isLower ? (char)value.Next(97, 122) : (char)value.Next(65, 90);
        }

        public static string NextString(this Random value, int length, bool isLower = true)
        {
            string word = string.Empty;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    word += value.NextChar(isLower);
                }
            }

            return word;
        }
    }
}
