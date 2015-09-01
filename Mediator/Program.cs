namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil UNSC = new UnitedNationsSecurityCouncil();

            USA c1 = new USA(UNSC);
            Iraq c2 = new Iraq(UNSC);

            UNSC.Country1 = c1;
            UNSC.Country2 = c2;

            c1.Declare("不准研制核武器，否则要发动战争！");
            c2.Declare("我们没研制核武器，也不怕侵略。");
        }
    }
}
