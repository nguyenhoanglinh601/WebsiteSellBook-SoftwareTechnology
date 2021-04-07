using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class TaiKhoanKhachHang
    {
        public int idKhachHang { get; set; }

        [Required]
        [Display(Name = "Họ tên")]
        public string tenKhachHang { get; set; }

        [Required]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime ngaySinh { get; set; }

        [Required]
        [Display(Name = "Giới tính")]
        public string gioiTinh { get; set; }

        [Required]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string soDienThoai { get; set; }

        [Required]
        [Display(Name = "Địa chỉ")]
        public string diaChi { get; set; }

        [Required]
        [Display(Name = "Điểm mua hàng")]
        public int diemMuaHang { get; set; }

        [Required]
        [Display(Name = "Tài khoản")]
        public string taiKhoan { get; set; }
        
        [Display(Name = "Mật khẩu")]
        public string matKhau { get; set; }

        [Display(Name = "Trạng thái")]
        public bool trangThai { get; set; }
        public ICollection<DonHang> danhSachDonHang { get; set; }
    }
}
