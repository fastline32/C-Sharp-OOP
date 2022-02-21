using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string ReturnRandomIndex()
        {
            int index = random.Next(0,Count);
            return this[index];
        }

        public string RemoveRandomElement()
        {
            int index = random.Next(0, Count);
            string value = this[index];
            RemoveAt(index);
            return value;
        }
    }
}
