using System;
using System.Collections.Generic;
using CollectionHierarchy.Interfaces;
using CollectionHierarchy.Models;

namespace CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        private IAddCollection<string> addCollection;
        private IAddRemoveCollection<string> addRemoveCollection;
        private IMyList<string> myList;

        public Engine()
        {
            addCollection = new AddCollection<string>();
            addRemoveCollection = new AddRemoveCollection<string>();
            myList = new MyList<string>();
        }
        public void Run()
        {
            string[] input = Console.ReadLine()!.Split();
            List<int> indexes = new List<int>();
            foreach (var item in input)
            {
                indexes.Add(addCollection.Add(item));
            }
            Console.WriteLine(string.Join(" ",indexes));
            //foreach (var item in input)
            //{
            //    Console.Write($"{addCollection.Add(item)}");
            //}

            //Console.WriteLine(Environment.NewLine);
            indexes.Clear();
            foreach (var item in input)
            {
                indexes.Add(addRemoveCollection.Add(item));
            }
            Console.WriteLine(string.Join(" ", indexes));

            indexes.Clear();
            foreach (var item in input)
            {
                indexes.Add(myList.Add(item));
            }
            Console.WriteLine(string.Join(" ", indexes));

            int numRemoveOperations = int.Parse(Console.ReadLine()!);
            List<string> removeItems = new List<string>();
            for (int i = 0; i < numRemoveOperations; i++)
            {
                removeItems.Add(addRemoveCollection.Remove());
            }
            Console.WriteLine(string.Join(" ",removeItems));
            removeItems.Clear();
            for (int i = 0; i < numRemoveOperations; i++)
            {
                removeItems.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ",removeItems));
        }
    }
}