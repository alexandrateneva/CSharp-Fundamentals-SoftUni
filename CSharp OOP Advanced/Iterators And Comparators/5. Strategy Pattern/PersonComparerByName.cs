namespace _5.Strategy_Pattern
{
    using System.Collections.Generic;

    public class PersonComparerByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var nameLengthCompare = x.Name.Length.CompareTo(y.Name.Length);
            if (nameLengthCompare != 0)
            {
                return nameLengthCompare;
            }
            return char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));
        }
    }
}
