using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class DonDatHang
    {
        public DonHang donHang { get; set; }
        public GioHang gioHang { get; set; }

        [Display(Name = "Trạng thái")]
        public string trangThai { get; set; }
    }
}
