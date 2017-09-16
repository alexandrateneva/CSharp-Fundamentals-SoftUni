namespace _3.Telephony.Interfaces
{
    using System.Collections.Generic;

    public interface ICallable
    {
        void Call(List<string> numbers);
    }
}
