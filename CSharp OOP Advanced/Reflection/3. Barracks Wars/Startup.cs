namespace _3.Barracks_Wars
{
    using _3.Barracks_Wars.Core;
    using _3.Barracks_Wars.Core.Factories;
    using _3.Barracks_Wars.Data;
    using _3.Barracks_Wars.Interfaces;

    public class Startup
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
