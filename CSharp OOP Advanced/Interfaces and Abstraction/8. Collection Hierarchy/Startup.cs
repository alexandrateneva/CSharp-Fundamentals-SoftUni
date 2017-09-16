namespace _8.Collection_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _8.Collection_Hierarchy.Interfaces;
    using _8.Collection_Hierarchy.Models;

    public class Startup
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split(' ').ToList();
            var amountOfRemoveOperations = int.Parse(Console.ReadLine());

            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var allCollections = new List<Collection>();
            allCollections.Add(addCollection);
            allCollections.Add(addRemoveCollection);
            allCollections.Add(myList);

            foreach (var collection in allCollections)
            {
                var indexes = new List<int>();
                foreach (var element in elements)
                {
                    var currentIndex = collection.Add(element);
                    indexes.Add(currentIndex);
                }
                Console.WriteLine(string.Join(" ", indexes));
            }

            var removableCollections = new List<IRemove>();
            removableCollections.Add(addRemoveCollection);
            removableCollections.Add(myList);

            foreach (var collection in removableCollections)
            {
                var removedWords = new List<string>();
                for (int i = 0; i < amountOfRemoveOperations; i++)
                {
                    removedWords.Add(collection.Remove());
                }
                Console.WriteLine(string.Join(" ", removedWords));
                removedWords.Clear();
            }
        }
    }
}
