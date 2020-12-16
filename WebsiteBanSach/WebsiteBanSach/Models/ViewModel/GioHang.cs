using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class GioHang
    {
        public List<ThanhPhanGioHang> tapHopSanPham = new List<ThanhPhanGioHang>();
        public IEnumerable<NhaXuatBan> danhSachNXB { get; set; }
        public IEnumerable<LoaiSach> tapHopLoaiSach { get; set; }
    }
}
