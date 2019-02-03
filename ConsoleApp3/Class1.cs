using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FloaterRecord
    {
        public string endDt { get; set; }
        public string featureCode { get; set; }
        public string firstResetDate { get; set; }
        public string flagIndexRound { get; set; }
        public int grossMargin { get; set; }
        public string index0 { get; set; }
        public string indx2 { get; set; }
        public int initialCoupon { get; set; }
        public string lookbackAdjustMeth { get; set; }
        public string lookbackConv { get; set; }
        public int margin { get; set; }
        public int mult { get; set; }
        public string resetCal { get; set; }
        public string resetFreq { get; set; }
        public string resetFreqDtl { get; set; }
        public int resetTerm { get; set; }
        public int spread { get; set; }
        public string startDt { get; set; }
        public string suspensionDayConv { get; set; }
    }

    public class FloaterSet
    {
        public List<FloaterRecord> floaterRecord { get; set; }
    }

    public class BlackRockData
    {
        public string accrualDt { get; set; }
        public int calcType { get; set; }
        public string cdInstmtType { get; set; }
        public DateTime changeDt { get; set; }
        public int compoundFlag { get; set; }
        public string country { get; set; }
        public string coupFreq { get; set; }
        public string couponFloat { get; set; }
        public string cpnType { get; set; }
        public string currency { get; set; }
        public string cusip { get; set; }
        public string cusipType { get; set; }
        public string dateConv { get; set; }
        public string descInstmt { get; set; }
        public string endAdjFlag { get; set; }
        public string firstPayDt { get; set; }
        public string firstSettleDt { get; set; }
        public string flagEom { get; set; }
        public FloaterSet floaterSet { get; set; }
        public string issueDt { get; set; }
        public string issuerId { get; set; }
        public string liquidity { get; set; }
        public string market { get; set; }
        public string maturity { get; set; }
        public string modifiedBy { get; set; }
        public string ntlFlag { get; set; }
        public string pmtAdjMeth { get; set; }
        public string pmtCal { get; set; }
        public string pmtFreqType { get; set; }
        public string pmtLocation { get; set; }
        public string priceAsPct { get; set; }
        public string roundFlag { get; set; }
        public int roundPrecision { get; set; }
        public string secType { get; set; }
        public string settleLocation { get; set; }
        public string smSecGroup { get; set; }
        public string smSecType { get; set; }
        public int strikeCap { get; set; }
        public string ticker { get; set; }
        public string wiFlag { get; set; }
    }
}
