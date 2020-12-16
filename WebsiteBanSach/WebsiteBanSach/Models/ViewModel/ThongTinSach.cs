using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class ThongTinSach
    {
        public Sach sach { get; set; }
        public string NXB { get; set; }
        public string loaiSach { get; set; }

        public string[] tacGia { get; set; }
    }
}
