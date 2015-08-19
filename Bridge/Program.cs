using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new Abstraction();
            
            ab.SetImplementor(new ConcreteImplementA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementB());
            ab.Operation();

            Console.Read();
        }
    }
}
