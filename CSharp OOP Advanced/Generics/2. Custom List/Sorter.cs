namespace _2.Custom_List
{
    using System;
    using System.Linq;

    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> list)
            where T : IComparable
        {
            var temp = list.Data.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}
