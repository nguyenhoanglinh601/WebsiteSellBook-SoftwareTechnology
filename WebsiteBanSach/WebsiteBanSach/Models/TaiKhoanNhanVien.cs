using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class TaiKhoanNhanVien
    {
        [Display(Name ="Mã nhân viên")]
        public int idNhanVien { get; set; }

        [Display(Name ="Họ tên")]
        public string tenNhanVien { get; set; }

        [Display(Name = "Số điện thoại")]
        public string soDienThoai { get; set; }

        [Display(Name = "Vai trò")]
        public string vaiTro { get; set; }

        [Display(Name = "Mật khẩu")]
        public string matKhau { get; set; }

        [Display(Name = "Trạng thái")]
        public bool trangThai { get; set; }
        public ICollection<TrangThaiDonHang> danhSachTrangThaiDonHang { get; set; }
    }
}
