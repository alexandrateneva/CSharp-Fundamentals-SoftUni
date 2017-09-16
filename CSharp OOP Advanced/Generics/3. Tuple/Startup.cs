namespace _3.Tuple
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var tupleForAdress = new Tuple<string, string>();
            var tupleForBeer = new Tuple<string, int>();
            var tupleForNumbers = new Tuple<int, double>();

            var adressInfo = Console.ReadLine().Split(' ');
            tupleForAdress.Item1 = adressInfo[0] + " " + adressInfo[1];
            tupleForAdress.Item2 = adressInfo[2];

            var beerInfo = Console.ReadLine().Split(' ');
            tupleForBeer.Item1 = beerInfo[0];
            tupleForBeer.Item2 = int.Parse(beerInfo[1]);

            var numbersInfo = Console.ReadLine().Split(' ');
            tupleForNumbers.Item1 = int.Parse(numbersInfo[0]);
            tupleForNumbers.Item2 = double.Parse(numbersInfo[1]);

            Console.WriteLine(tupleForAdress);
            Console.WriteLine(tupleForBeer);
            Console.WriteLine(tupleForNumbers);
        }
    }
}
