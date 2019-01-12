using System;
using System.Globalization;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo myCulture = new CultureInfo(2);
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            //DateTime dt =
            // DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine(startDate);
            Console.WriteLine(endDate);
            DateTime[] holidays = new DateTime[]
            {
    new DateTime(2016, 1, 1),
    new DateTime(2016, 3, 3),
    new DateTime(2016, 5, 1),
    new DateTime(2016, 5, 6),
    new DateTime(year:0-9999, 2, 3),
    new DateTime()

            };
        }
    }
}
