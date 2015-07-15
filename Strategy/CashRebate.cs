namespace Strategy
{
    public class CashRebate : CashSuper
    {
        private readonly double _rebate;
        public CashRebate(double rebate)
        {
            this._rebate = rebate;
        }

        public override double AcceptCash(double money)
        {
            return money*_rebate;
        }
    }
}
