namespace FactoryMethod
{
    public class SubFactory : IFactory
    {
        public Operate CreateOperate()
        {
            return new OperaSub();
        }
    }
}
