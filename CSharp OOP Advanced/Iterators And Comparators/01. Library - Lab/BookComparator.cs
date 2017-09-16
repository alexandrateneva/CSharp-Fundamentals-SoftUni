namespace _01.Library___Lab
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            var nameCompare = x.Title.CompareTo(y.Title);
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            return y.Year.CompareTo(x.Year);
        }
    }
}
