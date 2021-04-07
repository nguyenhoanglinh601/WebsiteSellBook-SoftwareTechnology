using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class NhaXuatBan
    {
        
        [Display(Name = "Mã nhà xuất bản")]
        public int idNhaXuatBan { get; set; }

        [Required(ErrorMessage ="trường này không được để trống")]
        [Display(Name = "Tên")]
        public string ten { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        [Display(Name = "Số điện thoại")]
        public string soDienThoai { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        [Display(Name = "Địa chỉ")]
        public string diaChi { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        public string email { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        public string website { get; set; }

        public ICollection<Sach> tapHopSach { get; set; }
    }
}
