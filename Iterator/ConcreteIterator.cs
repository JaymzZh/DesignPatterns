namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private int current = 0;

        private ConcreteAggregate aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        
        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }

    public class ConcreteIteratorDesc : Iterator
    {
        private int current = 0;

        private ConcreteAggregate aggregate;

        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            this.current = aggregate.Count - 1;
        }
        
        public override object First()
        {
            return aggregate[current - 1];
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current >= 0)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current < 0;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
