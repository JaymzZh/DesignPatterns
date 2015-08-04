namespace Adapter
{
    public class Translator : Player
    {
        private ForeignCenter foreignCenter = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            foreignCenter.Name = name;
        }

        public override void Attack()
        {
            foreignCenter.进攻();
        }

        public override void Defense()
        {
            foreignCenter.防守();
        }
    }
}
