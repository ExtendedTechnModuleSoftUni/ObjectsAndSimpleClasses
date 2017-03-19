namespace _01L.DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
