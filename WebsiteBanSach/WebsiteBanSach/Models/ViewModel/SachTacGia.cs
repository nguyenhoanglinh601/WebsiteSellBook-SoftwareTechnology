using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class SachTacGia
    {
        public ChiTietSach chiTietSach { get; set; }
        public IEnumerable<Sach> sach { get; set; }
        public IEnumerable<TacGia> tacGia { get; set; }
    }
}
