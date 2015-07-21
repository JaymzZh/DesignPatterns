namespace FactoryMethod
{
    public class DivFactory : IFactory
    {
        public Operate CreateOperate()
        {
            return new OperaDiv();
        }
    }
}
