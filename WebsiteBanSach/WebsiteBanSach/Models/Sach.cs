using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models
{
    public class Sach
    {
        [Display(Name ="Mã sách")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSach { get; set; }

        [Display(Name = "Lần tái bản")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lanTaiBan { get; set; }

        [Display(Name = "tên sách")]
        public string ten { get; set; }
        public int idNhaXuatBan { get; set; }
        public int maLoai { get; set; }

        [Display(Name = "Giá bán")]
        public decimal giaBan { get; set; }

        [Display(Name = "Số lượng")]
        public int soLuong { get; set; }

        [Display(Name = "Mô tả")]
        public string moTa { get; set; }

        [Display(Name = "Hình ảnh")]
        public string hinhAnh { get; set; }

        [Display(Name = "trạng thái")]
        public bool trangThai { get; set; }
        public NhaXuatBan nhaXuatBan { get; set; }
        public LoaiSach loaiSach { get; set; }
        public ICollection<ChiTietDonHang> danhSachChiTietDonHang { get; set; }
        public ICollection<ChiTietSach> tapHopChiTietSach { get; set; }
    }
}
