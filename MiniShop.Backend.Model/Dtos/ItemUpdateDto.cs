﻿using System.ComponentModel.DataAnnotations;
using MiniShop.Backend.Model.Enums;

namespace MiniShop.Backend.Model.Dto
{
    public class ItemUpdateDto
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int Id { get; set; }

        [Display(Name = "类别ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int CategorieId { get; set; }

        [Display(Name = "类别")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string CategorieName { get; set; }

        [Display(Name = "条码")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string Code { get; set; }

        [Display(Name = "名称")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string Name { get; set; }

        [Display(Name = "进货价")]
        [Required(ErrorMessage = "{0},不能为空")]
        public decimal PurchasePrice { get; set; }

        [Display(Name = "售价")]
        [Required(ErrorMessage = "{0},不能为空")]
        public decimal Price { get; set; }

        [Display(Name = "状态")]
        [Required(ErrorMessage = "{0},不能为空")]
        public EnumItemStatus State { get; set; }

        [Display(Name = "类型")]
        [Required(ErrorMessage = "{0},不能为空")]
        public EnumItemType Type { get; set; }

        [Display(Name = "供应商ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int SupplierId { get; set; }

        [Display(Name = "供应商名称")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string SupplierName { get; set; }

        [Display(Name = "计价方式")]
        [Required(ErrorMessage = "{0},不能为空")]
        public EnumPriceType PriceType { get; set; }

        [Display(Name = "单位ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int UnitId { get; set; }

        [Display(Name = "单位名称")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string UnitName { get; set; }

        [Display(Name = "图片")]
        public string Picture { get; set; }
    }
}
