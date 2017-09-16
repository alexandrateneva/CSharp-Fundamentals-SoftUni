namespace Hell
{
    using Hell.Core;
    using Hell.Interfaces;
    using Hell.Interfaces.IO;
    using Hell.IO;

    public class StartUp
    {
        public static void Main()
        {
            IInputReader reader = new InputReader();
            IOutputWriter writer = new OutputWriter();
            IManager manager = new HeroManager();

            Engine engine = new Engine(reader, writer, manager);
            engine.Run();
        }
    }
}