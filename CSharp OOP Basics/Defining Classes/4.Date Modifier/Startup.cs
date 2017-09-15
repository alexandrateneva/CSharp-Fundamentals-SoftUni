namespace _4.Date_Modifier
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd",
                System.Globalization.CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd",
                System.Globalization.CultureInfo.InvariantCulture);

            DateModifier currentDateModifier = new DateModifier(startDate, endDate);
            Console.WriteLine(currentDateModifier.GetDifference());
        }
    }
}
