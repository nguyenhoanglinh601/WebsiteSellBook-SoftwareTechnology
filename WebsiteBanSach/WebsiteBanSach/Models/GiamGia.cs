using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class GiamGia
    {
        public int idGiamGia { get; set; }
        public string tenChuongTrinh { get; set; }
        public decimal soTienGiam { get; set; }
        public ICollection<ChiTietGiamGia> danhSachChiTietGiamGia { get; set; }
    }
}
