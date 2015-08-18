using System.Collections.Generic;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count { get { return items.Count; } }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value);}
        }
    }
}
