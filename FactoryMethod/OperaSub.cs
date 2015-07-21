namespace FactoryMethod
{
    public class OperaSub : Operate
    {
        public override double GetResult()
        {
            return NumLeft - NumRight;
        }
    }
}
