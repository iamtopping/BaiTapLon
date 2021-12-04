using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        [Display(Name = "Tên khách hàng"), Required]
        public string TenKhachHang { get; set; }
        [Display(Name = "Số điện thoại")]
        public int SDT { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}