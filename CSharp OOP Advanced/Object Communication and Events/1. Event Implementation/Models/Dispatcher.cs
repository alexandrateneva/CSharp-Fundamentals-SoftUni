namespace _1.Event_Implementation.Models
{
    using System;

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get => this.name;
            set
            {
                this.OnNameChange(new NameChangeEventArgs(value));
                this.name = value;
            }
        }

        public event EventHandler NameChange;

        public void OnNameChange(NameChangeEventArgs args)
        {
            this.NameChange(this, args);
        }
    }
}