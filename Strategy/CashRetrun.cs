using System;

namespace Strategy
{
    public class CashRetrun : CashSuper
    {
        private readonly double _moneyConditon;
        private readonly double _moneyRetrun;

        public CashRetrun(double moneyCondition, double moneyRetrun)
        {
            this._moneyConditon = moneyCondition;
            this._moneyRetrun = moneyRetrun;
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= _moneyConditon)
                result = money - Math.Floor(money/_moneyConditon)*_moneyRetrun;
            return result;
        }
    }
}
