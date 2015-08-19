namespace Bridge
{
    public class Abstraction
    {
        protected Implementor Implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.Implementor = implementor;
        }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
