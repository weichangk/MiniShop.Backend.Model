using System.ComponentModel.DataAnnotations;

namespace MiniShop.Backend.Model.Dto
{
    public class PurchaseOderItemUpdateDto
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int Id { get; set; }

        [Display(Name = "商品ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int ItemId { get; set; }
        
        [Display(Name = "货号")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string ItemCode { get; set; }

        [Display(Name = "品名")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string ItemName { get; set; }

        [Display(Name = "单位")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string UnitName { get; set; }

        [Display(Name = "进货价")]
        public decimal PurchasePrice { get; set; }

        [Display(Name = "数量")]
        [Range(0.01,99999, ErrorMessage = "{0},在 0.01 - 99999 之间")]
        public decimal Number { get; set; }

        [Display(Name = "赠送数量")]
        [Range(0.01, 999, ErrorMessage = "{0},在 0.01 - 999 之间")]
        public decimal GiveNumber { get; set; }

        [Display(Name = "小计金额")]
        [Required(ErrorMessage = "{0},不能为空")]
        public decimal Amount { get; set; }

        [Display(Name = "实际进货价")]
        [Required(ErrorMessage = "{0},不能为空")]
        public decimal RealPurchasePrice { get; set; }
    }
}
