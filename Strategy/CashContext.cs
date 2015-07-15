namespace Strategy
{
    public class CashContext
    {
        private readonly CashSuper _cashSuper;

        public CashContext(string type)
        {
            switch (type)
            {
                case "满300减100":
                    _cashSuper = new CashRetrun(300, 100);
                    break;
                case "打8折":
                    _cashSuper = new CashRebate(0.8);
                    break;
                case "正常收费":
                default:
                    _cashSuper = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}
