using MiniShop.Backend.Model.Code;
using MiniShop.Backend.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Backend.Model.Dto
{
    public class PromotionOderAuditDto
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int Id { get; set; }

        [Display(Name = "审核状态")]
        public EnumAuditStatus AuditState { get; set; }

        [Display(Name = "审核人员")]
        public string AuditOperatorName { get; set; }

        [Display(Name = "审核日期")]
        public DateTime? AuditTime { get; set; }
    }
}
