namespace Mediator
{
    public class UnitedNationsSecurityCouncil : UniteNations
    {
        private USA country1;
        private Iraq country2;

        public USA Country1
        {
            set { country1 = value; }
        }

        public Iraq Country2
        {
            set { country2 = value; }
        }

        public override void Declare(string message, Country country)
        {
            if (country == country1)
            {
                country2.GetMessage(message);
            }
            else
            {
                country1.GetMessage(message);
            }
        }
    }
}
