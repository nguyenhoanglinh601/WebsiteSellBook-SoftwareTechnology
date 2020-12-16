using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public enum GioiTinh
    {
        male, female
    }
    public class TacGia
    {
        [Required(ErrorMessage = "trường này không được để trống")]
        public int idTacGia { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        [Display(Name = "tên tác giả")]
        public string ten { get; set; }

        [Required(ErrorMessage = "trường này không được để trống, giá trị được chấp nhận: [male] hoặc [female]")]
        [Display(Name = "giới tính")]
        public GioiTinh? gioiTinh { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        [Display(Name = "năm sinh")]
        [DataType(DataType.Date)]
        public DateTime namSinh { get; set; }

        [Required(ErrorMessage = "trường này không được để trống")]
        [Display(Name = "quốc tịch")]
        public string quocTich { get; set; }
        public ICollection<ChiTietSach> tapHopChiTietSach { get; set; }
    }
}
