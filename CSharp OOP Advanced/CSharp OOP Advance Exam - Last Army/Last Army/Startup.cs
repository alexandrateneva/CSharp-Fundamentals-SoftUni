namespace Last_Army
{
    using Last_Army.Core;
    using Last_Army.Core.IO;
    using Last_Army.Interfaces.IO;

    public class LastArmyMain
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            GameController gameController = new GameController(writer);
            Engine engine = new Engine(reader, writer, gameController);

            engine.Run();
        }
    }
}