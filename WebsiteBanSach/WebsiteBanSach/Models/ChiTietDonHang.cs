using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class ChiTietDonHang
    {
        public int idDonHang { get; set; }
        public int idSach { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
        public DonHang donHang { get; set; }
        public Sach sach { get; set; }

    }
}
