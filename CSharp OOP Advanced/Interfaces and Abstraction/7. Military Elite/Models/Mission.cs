namespace _7.Military_Elite.Models
{
    using _7.Military_Elite.Interfaces;

    public class Mission : IMission
    {
        public string CodeName { get; }
        public string State { get; private set; }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        
        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public bool IsValid()
        {
            if (this.State == "inProgress" || this.State == "Finished")
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
