using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class ThanhPhanGioHang
    {
        public Sach sach { get; set; }

        [Display(Name = "Số lượng")]
        public int soLuong { get; set; }
        public IEnumerable<NhaXuatBan> danhSachNXB { get; set; }
        public IEnumerable<LoaiSach> tapHopLoaiSach { get; set; }
    }
}
