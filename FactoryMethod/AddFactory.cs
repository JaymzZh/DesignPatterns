namespace FactoryMethod
{
    public class AddFactory : IFactory
    {
        public Operate CreateOperate()
        {
            return new OperaAdd();
        }
    }
}
