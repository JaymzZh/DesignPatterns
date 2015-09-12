using System;

namespace Interpreter
{
    public class Note : AbstractExpression
    {
        public override void Excute(string playKey, double playValue)
        {
            string note = string.Empty;
            switch (playKey)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "B";
                    break;
            }
            Console.Write("{0} ", note);
        }
    }
}
