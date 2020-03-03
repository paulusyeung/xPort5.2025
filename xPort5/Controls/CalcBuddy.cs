using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPort5.Controls
{
    public class CalcBuddy
    {
        #region private properties
        private int _PriceMethod = 0;
        private Decimal _FactoryCost = 0;
        private Decimal _Margin = 0;
        private Decimal _QuotedPrice = 0;
        private Decimal _Factor = 0;
        private Decimal _XchgRate = 0;
        private Decimal _XchgRate4Factory = 0;
        private Decimal _VolumnCUFT = 0;
        private Decimal _OuterBox = 0;
        private Decimal _PayCost = 0;
        private String _QuotedUnit = String.Empty;
        private String _FactoryUnit = String.Empty;
        private int _InputMask = 5;

        private Decimal _Multiplier = 1;
        #endregion

        #region public properties
        public int PriceMethod
        {
            get { return _PriceMethod; }
            set { _PriceMethod = value; }
        }
        public Decimal FactoryCost
        {
            get { return _FactoryCost; }
            set { _FactoryCost = value; }
        }
        public Decimal Margin
        {
            get { return _Margin * 100; }       // 把 Percentage 轉換為 小數點
            set { _Margin = value / 100; }      // 把 小數點 轉換為 Percentage
        }
        public Decimal QuotedPrice
        {
            get { return _QuotedPrice; }
            set { _QuotedPrice = value; }
        }
        public Decimal Factor
        {
            get { return _Factor; }
            set { _Factor = value; }
        }
        public Decimal ExchangeRate
        {
            get { return _XchgRate; }
            set { _XchgRate = value; }
        }
        public Decimal ExchangeRate4Factory
        {
            get { return _XchgRate4Factory; }
            set { _XchgRate4Factory = value; }
        }
        public Decimal VolumnCUFT
        {
            get { return _VolumnCUFT; }
            set { _VolumnCUFT = value; }
        }
        public Decimal OuterBox
        {
            get { return _OuterBox; }
            set { _OuterBox = value; }
        }
        public Decimal PayCost
        {
            get { return _PayCost; }
            set { _PayCost = value; }
        }
        public String QuotedUnit
        {
            get { return _QuotedUnit; }
            set { _QuotedUnit = value; }
        }
        public String FactoryUnit
        {
            get { return _FactoryUnit; }
            set { _FactoryUnit = value; }
        }
        public int InputMask
        {
            get { return _InputMask; }
            set { _InputMask = value; }
        }
        #endregion

        public void Calc()
        {
            LoadMultiplier();

            switch (_InputMask)
            {
                case 1:
                case 2:
                    CalcQuotedPrice();
                    break;
                case 3:
                    CalcFactoryCost();
                    break;
                case 4:
                    CalcMargin();
                    break;
                case 5:
                default:
                    CalcMode5();
                    break;
            }
        }

        public void CalcQuotedPrice()
        {
            Decimal _FactoryCostInLocalCny = _FactoryCost * _XchgRate4Factory;
            Decimal _ShipmentFee = Math.Round(_VolumnCUFT * _Factor / _OuterBox, 4);

            Decimal _NetPriceInLocalCny = 0;

            switch (_PriceMethod)
            {
                case 1:
                case 2:
                    // 參考舊 VB code：
                    //.Amount = (.VolCUFT * .Factor / .OuterBox + .FactoryCost) / _
                    //       (1 - .Margin) / .XchgRate + .PayCost
                    //
                    _NetPriceInLocalCny = Math.Round(((_ShipmentFee + _FactoryCostInLocalCny) / (1 - _Margin)), 4);
                    _QuotedPrice = Math.Round((_NetPriceInLocalCny * _Multiplier / _XchgRate + _PayCost), 4);
                    break;
                case 0:
                default:
                    // 參考舊 VB code：
                    //.Amount = .FactoryCost / (1 - .Margin) / .XchgRate
                    //.Amount = GetUnitXchg(.FactoryUnit, .Amount, .QuotingUnit) + .PayCost
                    //
                    _NetPriceInLocalCny = Math.Round((_FactoryCostInLocalCny / (1 - _Margin)), 4);
                    _QuotedPrice = Math.Round((_NetPriceInLocalCny * _Multiplier / _XchgRate + _PayCost), 4);
                    break;
            }
        }

        public void CalcFactoryCost()
        {
            Decimal _FactoryCostInLocalCny = _FactoryCost * _XchgRate4Factory;

            Decimal _NetPrice = Math.Round(_QuotedPrice / _Multiplier - _PayCost, 4);
            Decimal _NetPriceInLocalCny = Math.Round(_NetPrice * _XchgRate, 4);
            Decimal _ShipmentFee = Math.Round(_VolumnCUFT * _Factor / _OuterBox, 4);

            switch (_PriceMethod)
            {
                case 1:
                case 2:
                    // 參考舊 VB code：
                    //.FactoryCost = ((.Amount - .PayCost) * .XchgRate * (1 - .Margin)) - _
                    //               (.VolCUFT * .Factor / .OuterBox)
                    _FactoryCostInLocalCny = Math.Round(_NetPriceInLocalCny * (1 - _Margin), 4) - _ShipmentFee;
                    _FactoryCost = Math.Round((_FactoryCostInLocalCny / _XchgRate4Factory), 4);
                    break;
                case 0:
                default:
                    // 參考舊 VB code：
                    //.FactoryCost = ((GetUnitXchg(.QuotingUnit, (.Amount - .PayCost), .FactoryUnit)) _
                    //               * .XchgRate * (1 - .Margin))
                    _FactoryCostInLocalCny = Math.Round(_NetPriceInLocalCny * (1 - _Margin), 4);
                    _FactoryCost = Math.Round((_FactoryCostInLocalCny / _XchgRate4Factory), 4);
                    break;
            }
        }

        public void CalcMargin()
        {
            Decimal _FactoryCostInLocalCny = _FactoryCost * _XchgRate4Factory;

            Decimal _NetPrice = Math.Round(_QuotedPrice / _Multiplier - _PayCost, 4);
            Decimal _NetPriceInLocalCny = Math.Round(_NetPrice * _XchgRate, 4);
            Decimal _ShipmentFee = Math.Round(_VolumnCUFT * _Factor / _OuterBox, 4);

            switch (_PriceMethod)
            {
                case 1:
                case 2:
                    // 參考舊 VB code：
                    //.Margin = 1 - ((.VolCUFT * .Factor / .OuterBox + .FactoryCost) / _
                    //            .XchgRate / (.Amount - .PayCost))
                    //
                    _Margin = Math.Round(((_NetPriceInLocalCny - _ShipmentFee - _FactoryCostInLocalCny) / _NetPriceInLocalCny), 4);
                    break;
                case 0:
                default:
                    // 參考舊 VB code：
                    //.Margin = (1 - (.FactoryCost / .XchgRate / _
                    //          (GetUnitXchg(.QuotingUnit, (.Amount - .PayCost), .FactoryUnit))))
                    //
                    _Margin = Math.Round(((_NetPriceInLocalCny - _FactoryCostInLocalCny) / _NetPriceInLocalCny), 4);
                    break;
            }
        }

        private void CalcMode5()
        {
        }

        // 一般是 1 -> 12，常見：PC -> Dozen, Set -> Dozen Sets, Pair -> Dozen Pairs
        // 正常情況是：廠的 unit <= 賣出的 unit
        private void LoadMultiplier()
        {
            if (_QuotedUnit != _FactoryUnit)
                _Multiplier = 12;
            else
                _Multiplier = 1;
        }
    }
}
