namespace SimpleFactory
{
    public class OperaAdd : Operate
    {
        public override double GetResult()
        {
            return NumLeft + NumRight;
        }
    }
}
