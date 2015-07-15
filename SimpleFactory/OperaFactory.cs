namespace SimpleFactory
{
    public class OperaFactory
    {
        public static Operate CreateOpera(string oper)
        {
            switch (oper)
            {
                case "+":
                    return new OperaAdd();
                case "-":
                    return new OperaSub();
                case "*":
                    return new OperaMuti();
                case "/":
                    return new OperaDiv();
                default:
                    return new Operate();
            }
        }
    }
}
