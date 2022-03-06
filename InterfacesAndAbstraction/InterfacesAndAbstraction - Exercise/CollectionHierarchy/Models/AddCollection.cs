using System.Collections.Generic;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection<T> : IAddCollection<T>
    {
        private IList<T> collection;

        public AddCollection()
        {
            this.collection = new List<T>();
        }

        public virtual int Add(T element)
        {
            int index = collection.Count;
            collection.Add(element);
            return index;
        }
    }
}