namespace _1.ListyIterator
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var command = input[0];
            input.RemoveAt(0);
            var listyIterator = new ListyIterator<string>(input);

            while (command != "END")
            {
                switch (command)
                {
                    case "Create":
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                }

                input = Console.ReadLine().Split(' ').ToList();
                command = input[0];
            }
        }
    }
}
