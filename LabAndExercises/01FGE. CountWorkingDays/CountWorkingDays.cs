namespace _01FGE.CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main()
        {
            var startDateAsText = Console.ReadLine();
            var startDate = DateTime.ParseExact(startDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDateAsText = Console.ReadLine();
            var endDate = DateTime.ParseExact(endDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var oficialHolidays = new List<string>
            {
                "1 Jan",
                "3 Mar",
                "1 May",
                "6 May",
                "24 May",
                "6 Sep",
                "22 Sep",
                "1 Nov",
                "24 Dec",
                "25 Dec",
                "26 Dec",
            };

            int workingDaysCounter = GetWorkingDays(ref startDate, endDate, oficialHolidays);

            Console.WriteLine(workingDaysCounter);
        }

        static int GetWorkingDays(ref DateTime startDate, DateTime endDate, List<string> oficialHolidays)
        {
            int workingDaysCounter = 0;

            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var currentDayAndMonth = currentDate.Date.ToString("d MMM", CultureInfo.InvariantCulture);
                var dayOfWeek = currentDate.DayOfWeek.ToString();

                if (!oficialHolidays.Contains(currentDayAndMonth) && dayOfWeek != "Saturday" && dayOfWeek != "Sunday")
                {
                    workingDaysCounter++;
                }
            }

            return workingDaysCounter;
        }
    }
}
