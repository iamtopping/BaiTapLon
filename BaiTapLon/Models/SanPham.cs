using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public string MaSanPham { get; set; }
        [Display(Name = "Tên sản phẩm"), Required]
        public string TenSanPham { get; set; }
        [Display(Name = "Loại sản phẩm")]
        public string LoaiSanPham { get; set; }
        [Display(Name = "Số lượng")]
        public string SoLuong { get; set; }
        [Display(Name = "Khối lượng")]
        public string KhoiLuong { get; set; }
    }
}