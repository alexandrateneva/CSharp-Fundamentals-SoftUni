namespace CSharp_OOP_Basics_Exam___Minedraft.Models
{
    public abstract class Worker
    {
        private string id;

        protected Worker(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}