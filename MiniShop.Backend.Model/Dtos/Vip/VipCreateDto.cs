﻿using System;
using System.ComponentModel.DataAnnotations;
using MiniShop.Backend.Model.Code;
using MiniShop.Backend.Model.Enums;

namespace MiniShop.Backend.Model.Dto
{
    public class VipCreateDto
    {

        [Display(Name = "商店ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public Guid ShopId { get; set; }

        [Display(Name = "会员类别ID")]
        [Required(ErrorMessage = "{0},不能为空")]
        public int VipTypeId { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "卡号")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string Code { get; set; }

        [Display(Name = "性别")]
        public EnumSex Sex { get; set; }

        [Display(Name = "生日")]
        public DateTime Birthday { get; set; } = DateTime.Now;

        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string Password { get; set; }

        [Display(Name = "手机号")]
        [Required(ErrorMessage = "{0},不能为空")]
        public string Phone { get; set; }

        [Display(Name = "有效期")]
        public DateTime ValidDate { get; set; } = DateTime.Now;

        [Display(Name = "状态")]
        public EnumVipStatus State { get; set; }
    }
}
