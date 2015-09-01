namespace Mediator
{
    public abstract class Country
    {
        protected UniteNations mediator;

        public Country(UniteNations mediator)
        {
            this.mediator = mediator;
        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public abstract void GetMessage(string message);
    }
}
