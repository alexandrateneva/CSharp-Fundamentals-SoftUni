namespace _02.Monopoly
{
    using System;
    using System.Linq;

    public class Monopoly
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                var row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = row[j];
                }
            }

            var turns = 0;
            var totalSum = 50;
            var hotels = 0;
            char option;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var j2 = cols - 1 - j;
                    var currentCol = 0;
                    if (i % 2 == 0) { option = matrix[i][j]; currentCol = j; }
                    else { option = matrix[i][j2]; currentCol = j2; }

                    switch (option)
                    {
                        case 'H':
                            hotels++;
                            turns++;
                            Console.WriteLine($"Bought a hotel for {totalSum}. Total hotels: {hotels}.");
                            totalSum = 0;
                            break;
                        case 'J':
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 3;
                            totalSum += 10 * hotels * 2;
                            break;
                        case 'F': turns++; break;
                        case 'S':
                            var product = (i + 1) * (currentCol + 1);
                            var result = totalSum - product;
                            if (result < 0)
                            {
                                Console.WriteLine($"Spent {totalSum} money at the shop.");
                                totalSum = 0;
                            }
                            else
                            {
                                Console.WriteLine($"Spent {product} money at the shop.");
                                totalSum -= product;
                            }
                            turns++;
                            break;
                    }
                    totalSum += 10 * hotels;
                }
            }
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {totalSum}");
        }
    }
}

