using System;

namespace Euler19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1901, 1, 1);
            DateTime endDate = new DateTime(2000, 12, 31);
            TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
            TimeSpan oneWeek = new TimeSpan(7, 0, 0, 0);
            int counter = 0;

            while(date.DayOfWeek != DayOfWeek.Sunday)
            {
                date += oneDay;
            }

            while(date <= endDate)
            {
                if(date.Day == 1)
                {
                    counter++;
                }
                date += oneWeek;
            }

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
