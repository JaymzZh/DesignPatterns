using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            RoleStateCaretaker stateCaretaker = new RoleStateCaretaker {RoleStateMemento = lixiaoyao.SaveState()};

            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            lixiaoyao.RevcoveryState(stateCaretaker.RoleStateMemento);
            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
