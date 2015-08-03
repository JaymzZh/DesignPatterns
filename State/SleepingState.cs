using System;

namespace State
{
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 不行了，睡着了", w.Hour);
        }
    }
}
