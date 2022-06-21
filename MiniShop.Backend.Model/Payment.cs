using System;
using System.ComponentModel.DataAnnotations.Schema;
using MiniShop.Backend.Model.Enums;

namespace MiniShop.Backend.Model
{
    /// <summary>
    /// 采购收货订单商品信息
    /// </summary>
    public class Payment : EntityBaseNoDeletedStoreId<int>
    {
        /// <summary>
        /// 支付方式编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 是否启用状态
        /// </summary>
        public EnumEnableStatus Enable { get; set; }

        /// <summary>
        /// 是否系统内置支付方式
        /// </summary>
        public EnumYesOrNoStatus SystemPayment { get; set; }
    }
}
