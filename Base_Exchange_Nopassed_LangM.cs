using DbFrame.Class;
using System;

namespace Models
{
    [Table("base_exchange_nopassed_lang")]
    public class Base_Exchange_Nopassed_LangM : BaseEntity
    {
        [Field("自增ID", FieldType = typeof(int), IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        [Field("交易所Code")]
        public string ExchangeCode { get; set; }

        [Field("交易所英文名")]
        public string LangCode { get; set; }

        [Field("交易所本土名称")]
        public string ExchangeNativeCode { get; set; }

        [Field("交易所描述")]
        public string ExchangeDecription { get; set; }

        [Field("其他链接json")]
        public string LinksJson { get; set; }

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
