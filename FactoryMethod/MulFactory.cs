namespace FactoryMethod
{
    public class MulFactory : IFactory
    {
        public Operate CreateOperate()
        {
            return new OperaMuti();
        }
    }
}
