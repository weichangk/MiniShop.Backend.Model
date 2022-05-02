using MiniShop.Backend.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Backend.Model.Dto
{
    public class PurchaseOderUpdateDto
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int Id { get; set; }

        [Display(Name = "供应商ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int SupplierId { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
