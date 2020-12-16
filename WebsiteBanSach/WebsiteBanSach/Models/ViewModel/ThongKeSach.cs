using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class ThongKeSach
    {
        public IEnumerable<Sach> tapHopSach { get; set; }
        public IEnumerable<NhaXuatBan> danhSachNXB { get; set; }
        public IEnumerable<LoaiSach> tapHopLoaiSach { get; set; }
    }
}
