using System.Collections.Generic;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection<T> : AddCollection<T>,IAddRemoveCollection<T>
    {
        private IList<T> collection;

        public AddRemoveCollection()
        {
            this.collection = new List<T>();
        }

        public override int Add(T element)
        {
            this.collection.Insert(0,element);
            return 0;
        }

        public virtual T Remove()
        {
            T lastElement;
            if (collection.Count!=0)
            {
                lastElement = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                return lastElement;
            }

            return default;
        }
    }
}