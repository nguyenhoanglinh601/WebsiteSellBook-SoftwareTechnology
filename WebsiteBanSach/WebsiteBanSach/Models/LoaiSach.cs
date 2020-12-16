using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class LoaiSach
    {
        [Display(Name = "Mã loại sách")]
        public int idLoai { get; set; }

        [Display(Name = "Tên loại sách")]
        public string tenLoai { get; set; }

        [Display(Name = "Mô tả")]
        public string moTa { get; set; }
        public ICollection<Sach> tapHopSach { get; set; }
    }
}
