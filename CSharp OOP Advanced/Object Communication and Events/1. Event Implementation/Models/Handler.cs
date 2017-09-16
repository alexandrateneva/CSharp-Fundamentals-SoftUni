namespace _1.Event_Implementation.Models
{
    using System;

    public class Handler
    {
        public void SubscribeToDispatcher(Dispatcher dispatcher)
        {
            dispatcher.NameChange += this.OnDispatcherNameChange;
        }

        public void OnDispatcherNameChange(object sender, EventArgs args)
        {
            if (sender is Dispatcher eventSender && args is NameChangeEventArgs eventArgs)
            {
                Console.WriteLine($"Dispatcher's name changed to {eventArgs.Name}.");
            }
        }
    }
}
