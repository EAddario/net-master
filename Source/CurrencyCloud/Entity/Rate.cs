﻿using System;

namespace CurrencyCloud.Entity
{
    public class Rate : Entity
    {
        [Newtonsoft.Json.JsonConstructor]
        internal Rate() { }

        public DateTime SettlementCutOffTime { get; set; }

        ///<summary>
        /// Currency pair eg. EURUSD,GBPZAR
        ///</summary>
        public string CurrencyPair { get; set; }

        ///<summary>
        /// Currency you are converting to
        ///</summary>
        public string ClientBuyCurrency { get; set; }

        ///<summary>
        /// Currency you are converting from
        ///</summary>
        public string ClientSellCurrency { get; set; }

        public decimal ClientBuyAmount { get; set; }

        public decimal ClientSellAmount { get; set; }

        ///<summary>
        /// The currency that the amount applies to, either buy or sell
        ///</summary>
        public string FixedSide { get; set; }

        public decimal MidMarketRate { get; set; }

        public decimal CoreRate { get; set; }

        public decimal PartnerRate { get; set; }

        public decimal ClientRate { get; set; }

        public bool DepositRequired { get; set; }

        public decimal DepositAmount { get; set; }

        public string DepositCurrency { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Rate))
            {
                return false;
            }

            var rate = obj as Rate;

            return SettlementCutOffTime == rate.SettlementCutOffTime &&
                   CurrencyPair == rate.CurrencyPair &&
                   ClientBuyCurrency == rate.ClientBuyCurrency &&
                   ClientSellCurrency == rate.ClientSellCurrency &&
                   ClientBuyAmount == rate.ClientBuyAmount &&
                   ClientSellAmount == rate.ClientSellAmount &&
                   FixedSide == rate.FixedSide &&
                   MidMarketRate == rate.MidMarketRate &&
                   CoreRate == rate.CoreRate &&
                   PartnerRate == rate.PartnerRate &&
                   ClientRate == rate.ClientRate &&
                   DepositRequired == rate.DepositRequired &&
                   DepositAmount == rate.DepositAmount &&
                   DepositCurrency == rate.DepositCurrency;
        }

        public override int GetHashCode()
        {
            return CurrencyPair.GetHashCode();
        }
    }
}
