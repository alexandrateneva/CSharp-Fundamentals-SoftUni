namespace _1.Event_Implementation
{
    using System;
    using _1.Event_Implementation.Models;

    public class Startup
    {
        public static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();

            handler.SubscribeToDispatcher(dispatcher);

            var input = Console.ReadLine();
            while (input != "End")
            {
                dispatcher.Name = input;

                input = Console.ReadLine();
            }
        }
    }
}