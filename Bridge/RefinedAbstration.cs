namespace Bridge
{
    public class RefinedAbstration : Abstraction
    {
        public override void Operation()
        {
            Implementor.Operation();
        }
    }
}
