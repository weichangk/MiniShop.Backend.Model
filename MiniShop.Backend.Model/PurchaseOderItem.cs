using System.ComponentModel.DataAnnotations.Schema;

namespace MiniShop.Backend.Model
{
    /// <summary>
    /// 采购订单商品信息
    /// </summary>
    public class PurchaseOderItem : EntityBaseNoDeleted<int>
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OderNo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        /// <value></value>
        public string ItemCode { get; set; }

        /// <summary>
        /// 品名
        /// </summary>
        /// <value></value>
        public string ItemName { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value></value>
        public string UnitName { get; set; }

        /// <summary>
        /// 进货价
        /// </summary>
        /// <value></value>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Number { get; set; }

        /// <summary>
        /// 赠送数量
        /// </summary>
        public decimal GiveNumber { get; set; }

        /// <summary>
        /// 小计金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 实际进货价
        /// </summary>
        public decimal RealPurchasePrice { get; set; }

    }
}
