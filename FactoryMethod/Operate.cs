namespace FactoryMethod
{
    public class Operate
    {
        public double NumLeft { get; set; }
        public double NumRight { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
