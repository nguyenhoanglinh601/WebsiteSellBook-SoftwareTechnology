using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class ChiTietSach
    {
        public int idSach { get; set; }
        public int idTacGia { get; set; }
        public Sach sach { get; set; }
        public TacGia tacGia { get; set; }
    }
}
