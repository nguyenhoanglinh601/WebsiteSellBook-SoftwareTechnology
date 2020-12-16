using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class DonHangVaTrangThai
    {
        public DonHang donHang { get; set; }
        public string trangThaiDonhang { get; set; }

        public List<ThanhPhanGioHang> gioHang { get; set; }
    }
}
