using System;

namespace Interpreter
{
    public class Scale : AbstractExpression
    {
        public override void Excute(string playKey, double playValue)
        {
            string scale = string.Empty;
            switch (Convert.ToInt32(playValue))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write("{0} ", scale);
        }
    }
}
