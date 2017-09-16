namespace CSharp_OOP_Basics_Exam___Minedraft
{
    using CSharp_OOP_Basics_Exam___Minedraft.Core;

    public class StartUp
    {
        public static void Main()
        {
            var manager = new DraftManager();

            var engine = new Engine(manager);
            engine.Run();
        }
    }
}
