using System;

namespace State
{
    public class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 下班回家了", w.Hour);
        }
    }
}
