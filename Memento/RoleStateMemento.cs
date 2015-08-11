namespace Memento
{
    public class RoleStateMemento
    {
        public int Vitality { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public RoleStateMemento(int vit, int atk, int def)
        {
            Vitality = vit;
            Attack = atk;
            Defense = def;
        }
    }
}
