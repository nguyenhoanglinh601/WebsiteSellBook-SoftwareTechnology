using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class TrangThai
    {
        public int idTrangThai { get; set; }
        public string kieuTrangThai { get; set; }
        public ICollection<TrangThaiDonHang> danhSachTrangThaiDonHang { get; set; }
    }
}
