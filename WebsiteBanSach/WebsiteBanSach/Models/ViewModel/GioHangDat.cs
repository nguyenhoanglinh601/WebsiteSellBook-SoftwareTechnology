using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class GioHangDat
    {
        public GioHang gioHang { get; set; }
        public int maKhachHang { get; set; }

        [Display(Name="Số điện thoại người nhận")]
        public string soDienThoaiNguoiNhan { get; set; }

        [Display(Name = "Địa chỉ giao hàng")]
        public string diaChiGiaoHang { get; set; }
    }
}
