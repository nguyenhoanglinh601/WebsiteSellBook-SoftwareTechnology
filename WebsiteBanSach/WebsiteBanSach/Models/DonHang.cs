using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class DonHang
    {
        [Display(Name = "Mã đơn hàng")]
        public int idDonHang { get; set; }

        [Display(Name = "Mã khách hàng")]
        public int idKhachHang { get; set; }

        [Display(Name = "Tên người nhận")]
        public string tenNguoiNhan { get; set; }

        [Display(Name = "Thời gian đặt hàng")]
        public DateTime thoiGianDatHang { get; set; }

        [Display(Name = "Địa chỉ giao hàng")]
        public string diaChiGiaoHang { get; set; }

        [Display(Name = "Thời gian dự kiến giao hàng")]
        public DateTime thoiGianGiaoHangDuKien { get; set; }

        [Display(Name = "Phí giao hàng")]
        public decimal phiGiaoHang { get; set; }

        [Display(Name = "Số điện thoại")]
        public string soDienThoai { get; set; }

        [Display(Name = "VAT")]
        public decimal VAT { get; set; }

        [Display(Name = "Tổng tiền")]
        public decimal tongTien { get; set; }
        public ICollection<ChiTietDonHang> danhSachChiTietDonHang { get; set; }
        public ICollection<ChiTietGiamGia> danhSachChiTietGiamGia { get; set; }
        public ICollection<TrangThaiDonHang> danhSachTrangThaiDonHang { get; set; }
        public TaiKhoanKhachHang taiKhoanKhachHang { get; set; }
    }
}
