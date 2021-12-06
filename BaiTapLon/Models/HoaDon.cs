using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string HoaDonID { get; set; }
        public string KhachHangID { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; }
        public string Chitiet { get; set; }
        public KhachHang KhachHang { get; set; }
        


    }
}