namespace _02.Generic_Array_Creator___Lab
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lenght, T item)
        {
            T[] array = new T[lenght];
            return array;
        }
    }
}
