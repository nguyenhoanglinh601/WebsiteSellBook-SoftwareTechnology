using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class SachNXBLoai
    {
        public Sach sach { get; set; }
        public IEnumerable<NhaXuatBan> danhSachNhaXuatBan { get; set; }
        public IEnumerable<LoaiSach> danhSachLoai { get; set; }
    }
}
