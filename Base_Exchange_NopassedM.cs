using DbFrame.Class;
using System;

namespace Models
{
    [Table("base_exchange_nopassed")]
    public class Base_Exchange_NopassedM : BaseEntity
    {
        [Field("自增ID", FieldType = typeof(int), IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        [Field("交易所Code")]
        public string ExchangeCode { get; set; }

        [Field("交易所英文名")]
        public string ExchangeName { get; set; }

        [Field("交易所链接")]
        public string ExchangeUrl { get; set; }

        [Field("交易所图标地址")]
        public string ExchangeIconUrl { get; set; }

        [Field("交易所小图标")]
        public string ExchangeIconSmall { get; set; }

        [Field("交易所中图标")]
        public string ExchangeIconMid { get; set; }

        [Field("交易所大图标")]
        public string ExchangeIconBig { get; set; }

        [Field("交易所webp图标（主要用于app）")]
        public string ExchangeIconWebpMid { get; set; }

        [Field("平台币名称地址")]
        public string PlatformTokenCode { get; set; }
       
        [Field("平台币名称")]
        public string PlatformTokenName { get; set; }

        [Field("交易所标签")]
        public int SupportExchangeTypes { get; set; }

        [Field("评级")]
        public int ExchangeStar { get; set; }

        [Field("交易所发行时间")]
        public DateTime LaunchDate { get; set; }

        [Field("所在国家")]
        public string CountryCode { get; set; }

        [Field("是否挖矿交易所")]
        public bool IsTradingAsMining { get; set; }

        [Field("提供挖矿")]
        public string ProvideMining { get; set; }

        [Field("是否没有手续费")]
        public bool IsNoTradingFees { get; set; }
        
        [Field("所有交易对行情数据")]
        public string ApiUrl { get; set; }

        [Field("其他链接")]
        public string OtherLinks { get; set; }

        [Field("提交者姓名")]
        public string SubmitterName { get; set; }

        [Field("提交者邮箱")]
        public string SubmitterEmail { get; set; }

        [Field("提交者Telegream")]
        public string SubmitterTelegram { get; set; }

        [Field("备注")]
        public string Remark { get; set; }

        [Field("审核状态")]
        public int ReviewStatus { get; set; }

        [Field("创建时间")]
        public DateTime CreateTime { get; set; }

        [Field("资料修改时间")]
        public DateTime ModifyTime { get; set; }

        [Field("新增记录的后台操作人员的id")]
        public string AddOprID { get; set; }

        [Field("修改记录的后台操作人员的id")]
        public string EditOprID { get; set; }


    }
}
