using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class TrangThaiDonHang
    {
        public int idDonHang { get; set; }
        public int idTrangThai { get; set; }
        public int idNhanVien { get; set; }
        public DateTime thoiGian { get; set; }
        public DonHang donHang { get; set; }
        public TrangThai trangThai { get; set; }
        public TaiKhoanNhanVien taiKhoanNhanVien { get; set; }
    }
}
