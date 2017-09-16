namespace _4.Threeuple
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var threeupleForAdress = new Threeuple<string, string, string>();
            var threeupleForBeer = new Threeuple<string, int, bool>();
            var threeupleForBank = new Threeuple<string, double, string>();

            var adressInfo = Console.ReadLine().Split(' ');
            threeupleForAdress.Item1 = adressInfo[0] + " " + adressInfo[1];
            threeupleForAdress.Item2 = adressInfo[2];
            threeupleForAdress.Item3 = adressInfo[3];

            var beerInfo = Console.ReadLine().Split(' ');
            threeupleForBeer.Item1 = beerInfo[0];
            threeupleForBeer.Item2 = int.Parse(beerInfo[1]);
            if (beerInfo[2] == "drunk")
            {
                threeupleForBeer.Item3 = true;
            }

            var bankInfo = Console.ReadLine().Split(' ');
            threeupleForBank.Item1 = bankInfo[0];
            threeupleForBank.Item2 = double.Parse(bankInfo[1]);
            threeupleForBank.Item3 = bankInfo[2];

            Console.WriteLine(threeupleForAdress);
            Console.WriteLine(threeupleForBeer);
            Console.WriteLine(threeupleForBank);
        }
    }
}
