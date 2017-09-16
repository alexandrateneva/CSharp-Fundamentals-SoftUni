namespace _5.Strategy_Pattern
{
    using System.Collections.Generic;

    public class PersonComparerByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
