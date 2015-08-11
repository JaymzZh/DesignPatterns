using System;

namespace Memento
{
    public class GameRole
    {
        public int Vit { get; set; }

        public int Atk { get; set; }

        public int Def { get; set; }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vit, Atk, Def);
        }

        public void GetInitState()
        {
            this.Vit = 100;
            this.Atk = 100;
            this.Def = 100;
        }

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}", this.Vit);
            Console.WriteLine("攻击力：{0}", this.Atk);
            Console.WriteLine("防御力：{0}", this.Def);
            Console.WriteLine("");
        }

        public void Fight()
        {
            this.Vit = 0;
            this.Atk = 0;
            this.Def = 0;
        }

        public void RevcoveryState(RoleStateMemento memento)
        {
            this.Vit = memento.Vitality;
            this.Atk = memento.Attack;
            this.Def = memento.Defense;
        }
    }
}
