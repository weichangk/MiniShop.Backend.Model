using MiniShop.Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Backend.Model.Dto
{
    public class PurchaseOderCreateDto
    {
        [Display(Name = "商店ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public Guid ShopId { get; set; }

        [Display(Name = "单号")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string OderNo { get; set; }

        [Display(Name = "供应商ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int SupplierId { get; set; }

        [Display(Name = "供应商")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string SupplierName { get; set; }

        [Display(Name = "制单人员")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string OperatorName { get; set; }

        [Display(Name = "制单日期")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [Display(Name = "审核状态")]
        public EnumAuditStatus AuditState { get; set; } = EnumAuditStatus.UnAudited;

        [Display(Name = "订单状态")]
        public EnumPurchaseOrderStatus OrderState { get; set; } = EnumPurchaseOrderStatus.UnReceived;

        [Display(Name = "备注")]
        public string Remark { get; set; }

        [Display(Name = "订单创建成功标志")]
        public bool OrderCreatedFlag { get; set; }
    }
}
