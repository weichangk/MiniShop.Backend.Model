using MiniShop.Backend.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Backend.Model.Dto
{
    public class PurchaseOderUpdateDto
    {
        [Display(Name = "商店ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public Guid ShopId { get; set; }
        
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int Id { get; set; }

        [Display(Name = "供应商ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int SupplierId { get; set; }

        [Display(Name = "供应商")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string SupplierName { get; set; }

        [Display(Name = "审核状态")]
        public EnumAuditStatus AuditState { get; set; }

        [Display(Name = "订单状态")]
        public EnumPurchaseOrderStatus OrderState { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
