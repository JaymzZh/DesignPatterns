namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boy = new Barbecuer();
            Command bakeMutton1 = new BakeMuttonCommand(boy);
            Command bakeMutton2 = new BakeMuttonCommand(boy);
            Command bakeChickenWing = new BakeChickenWingCommand(boy);
            Waiter girl = new Waiter();

            girl.SetOrder(bakeMutton1);
            girl.SetOrder(bakeMutton2);
            girl.SetOrder(bakeChickenWing);
            girl.Notify();
        }
    }
}
