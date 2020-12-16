using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanSach.Data;
using WebsiteBanSach.Models;
using WebsiteBanSach.Models.ViewModel;

namespace WebsiteBanSach.Controllers
{
    public class DonHangController : Controller
    {
        private readonly WebBanSachContext _context;

        public DonHangController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult hienThiDanhSachDonHang(int idDonHang, int idTrangThaiDonHang,
            int? soTrang)
        {
            if(SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            List<DonHangVaTrangThai> danhSachDonHangVaTrangThai = new List<DonHangVaTrangThai>();
            var danhSachDonHang = _context.TapHopDonHang.Where(i => i.idKhachHang==SessionKhachHang.taiKhoan.idKhachHang).OrderByDescending(k => k.idDonHang).ToList();
            //var danhSachDonHang = _context.TapHopDonHang.Where(i => i.idKhachHang == 1).ToList();
            var danhSachTrangThai = _context.TapHopTrangThai.ToList();
            
            foreach (DonHang donHang in danhSachDonHang)
            {
                var danhSachTrangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang==donHang.idDonHang);
                var trangThaiDonHang = danhSachTrangThaiDonHang.Max(i => i.idTrangThai);
                var stringTrangThaiDonHang = danhSachTrangThai.Where(i => i.idTrangThai == trangThaiDonHang).FirstOrDefault();

                DonHangVaTrangThai donHangVaTrangThai = new DonHangVaTrangThai();
                donHangVaTrangThai.donHang = donHang;
                donHangVaTrangThai.trangThaiDonhang = stringTrangThaiDonHang.kieuTrangThai;

                danhSachDonHangVaTrangThai.Add(donHangVaTrangThai);
            }
            return View("HienThiDanhSachDonHang",danhSachDonHangVaTrangThai);
        }

        public IActionResult thongKeDonHang(int idDonHang, int idTrangThaiDonHang,
            string thuTuSapXep, int? soTrang)
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            List<DonHangVaTrangThai> danhSachDonHangVaTrangThai = new List<DonHangVaTrangThai>();
            var danhSachDonHang = _context.TapHopDonHang.OrderByDescending(i => i.idDonHang).ToList();
            var danhSachTrangThai = _context.TapHopTrangThai.ToList();

            foreach (DonHang donHang in danhSachDonHang)
            {
                var danhSachTrangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == donHang.idDonHang);
                var trangThaiDonHang = danhSachTrangThaiDonHang.Max(i => i.idTrangThai);
                var stringTrangThaiDonHang = danhSachTrangThai.Where(i => i.idTrangThai == trangThaiDonHang).FirstOrDefault();

                DonHangVaTrangThai donHangVaTrangThai = new DonHangVaTrangThai();
                donHangVaTrangThai.donHang = donHang;
                donHangVaTrangThai.trangThaiDonhang = stringTrangThaiDonHang.kieuTrangThai;

                danhSachDonHangVaTrangThai.Add(donHangVaTrangThai);
            }
            return View("ThongKeDonHang", danhSachDonHangVaTrangThai);
        }

        [HttpGet]
        public IActionResult xemDonHang(int? idDonHang)
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            var donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang & i.idKhachHang==SessionKhachHang.taiKhoan.idKhachHang).FirstOrDefault();

            if(donHang == null)
            {
                return RedirectToAction(nameof(hienThiDanhSachDonHang));
            }

            var gioHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            var trangThai = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == idDonHang).Max(t => t.idTrangThai);
            var stringTrangThai = _context.TapHopTrangThai.Where(i => i.idTrangThai == trangThai).FirstOrDefault().kieuTrangThai;

            List<ThanhPhanGioHang> danhSachThanhPhanGioHang = new List<ThanhPhanGioHang>();

            foreach (ChiTietDonHang chiTietDonHang in gioHang)
            {
                var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                sach.giaBan = chiTietDonHang.giaBan;

                ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();

                thanhPhanGioHang.sach = sach;
                thanhPhanGioHang.soLuong = chiTietDonHang.soLuong;
                thanhPhanGioHang.danhSachNXB = _context.TapHopNhaXuatBan.ToList();
                thanhPhanGioHang.tapHopLoaiSach = _context.TapHopLoaiSach.ToList();

                danhSachThanhPhanGioHang.Add(thanhPhanGioHang);
            }

            DonHangVaTrangThai donHangVaTrangThai = new DonHangVaTrangThai();
            donHangVaTrangThai.donHang = donHang;
            donHangVaTrangThai.gioHang = danhSachThanhPhanGioHang;
            donHangVaTrangThai.trangThaiDonhang = stringTrangThai;

            return View("XemDonDatHang", donHangVaTrangThai);
        }

        [HttpGet]
        public IActionResult datHang()
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            if (SessionKhachHang.gioHang.tapHopSanPham.LongCount() == 0)
            {
                return Redirect("../GioHang/xemGioHang");
            }
            return View("./datHang", SessionKhachHang.gioHang);
        }

        [HttpPost]
        public IActionResult datHang(string tenNguoiNhan, string diaChiGiaoHang, string soDienThoai)
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }
            DonHang donHang = new DonHang();
            donHang.idKhachHang = SessionKhachHang.taiKhoan.idKhachHang;
            //donHang.idKhachHang = 1;
            donHang.tenNguoiNhan = tenNguoiNhan;
            donHang.diaChiGiaoHang = diaChiGiaoHang;
            donHang.soDienThoai = soDienThoai;
            donHang.thoiGianDatHang = DateTime.Now;
            decimal tongTien = 0;
            foreach(ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
            {
                tongTien = tongTien + (thanhPhanGioHang.sach.giaBan * thanhPhanGioHang.soLuong);
            }
            donHang.VAT = (tongTien / 100) * 10;
            donHang.tongTien = tongTien + ((tongTien / 100) * 10);

            _context.Add(donHang);
            _context.SaveChanges();

            TrangThaiDonHang trangThaiDonHang = new TrangThaiDonHang();
            trangThaiDonHang.idTrangThai = 1;
            trangThaiDonHang.idDonHang = _context.TapHopDonHang.Max(i => i.idDonHang);
            trangThaiDonHang.thoiGian = DateTime.Now;

            _context.Add(trangThaiDonHang);
            _context.SaveChanges();

            foreach (ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
            {
                ChiTietDonHang chiTietDonHang = new ChiTietDonHang();
                chiTietDonHang.idDonHang = _context.TapHopDonHang.Max(i => i.idDonHang);
                chiTietDonHang.idSach = thanhPhanGioHang.sach.idSach;
                chiTietDonHang.soLuong = thanhPhanGioHang.soLuong;
                chiTietDonHang.giaBan = thanhPhanGioHang.sach.giaBan;
                
                _context.Add(chiTietDonHang);
                _context.SaveChanges();

            }

            var idDonHang = _context.TapHopDonHang.Max(i => i.idDonHang);
            var danhSachChiTietDonHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            foreach (var chiTietDonHang in danhSachChiTietDonHang)
            {
                var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                sach.soLuong = sach.soLuong - chiTietDonHang.soLuong;

                _context.Update(sach);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(hienThiDanhSachDonHang));
        }

        [HttpGet]
        public IActionResult suaThongTinDonHang(int idDonHang)
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            var donHang = _context.TapHopDonHang.Find(idDonHang);
            if(donHang == null || donHang.idKhachHang != SessionKhachHang.taiKhoan.idKhachHang)
            {
                return RedirectToAction(nameof(hienThiDanhSachDonHang));
            }

            return View("SuaThongTinDonHang", donHang);
        }

        [HttpPost]
        public IActionResult suaThongTinDonHang(int idDonHang, string tenNguoiNhan, string diaChiGiaoHang, string soDienThoai)
        {
            var donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang).FirstOrDefault();
            donHang.tenNguoiNhan = tenNguoiNhan;
            donHang.diaChiGiaoHang = diaChiGiaoHang;
            donHang.soDienThoai = soDienThoai;

            _context.Update(donHang);
            _context.SaveChanges();

            return RedirectToAction(nameof(hienThiDanhSachDonHang));
        }

        [HttpGet]
        public IActionResult xuLyDonHang(int? idDonHang)
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang).FirstOrDefault();
            var gioHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            var trangThai = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == idDonHang).Max(t => t.idTrangThai);
            var stringTrangThai = _context.TapHopTrangThai.Where(i => i.idTrangThai == trangThai).FirstOrDefault().kieuTrangThai;

            //ViewData["test"] = stringTrangThai.kieuTrangThai;
            //return View("../Debug");

            List<ThanhPhanGioHang> danhSachThanhPhanGioHang = new List<ThanhPhanGioHang>();

            foreach(ChiTietDonHang chiTietDonHang in gioHang)
            {
                var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                sach.giaBan = chiTietDonHang.giaBan;

                ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();

                thanhPhanGioHang.sach = sach;
                thanhPhanGioHang.soLuong = chiTietDonHang.soLuong;
                thanhPhanGioHang.danhSachNXB = _context.TapHopNhaXuatBan.ToList();
                thanhPhanGioHang.tapHopLoaiSach = _context.TapHopLoaiSach.ToList();

                danhSachThanhPhanGioHang.Add(thanhPhanGioHang);
            }

            DonHangVaTrangThai donHangVaTrangThai = new DonHangVaTrangThai();
            donHangVaTrangThai.donHang = donHang;
            donHangVaTrangThai.gioHang = danhSachThanhPhanGioHang;
            donHangVaTrangThai.trangThaiDonhang = stringTrangThai;

            return View("xuLyDonHang",donHangVaTrangThai);
        }

        [HttpPost]
        public IActionResult xuLyDonHang(int idDonHang, int idTrangThai, string thoiGianGiaoHangDuKien, string phiGiaoHang)
        {

            DonHang donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang).FirstOrDefault();
            donHang.thoiGianGiaoHangDuKien = DateTime.Parse(thoiGianGiaoHangDuKien);
            donHang.phiGiaoHang = Decimal.Parse(phiGiaoHang);

            _context.Update(donHang);
            _context.SaveChanges();

            TrangThaiDonHang trangThaiDonHang = new TrangThaiDonHang();
            trangThaiDonHang.idDonHang = idDonHang;
            //trangThaiDonHang.idNhanVien = SessionNhanVien.taiKhoan.idNhanVien;
            trangThaiDonHang.idNhanVien = 1;
            trangThaiDonHang.idTrangThai = idTrangThai;

            bool kiemTraTrangThaiDonHang = false;

            foreach(TrangThaiDonHang trangThaiDonHangKT in _context.TapHopTrangThaiDonHang.ToList())
            {

                if((trangThaiDonHangKT.idDonHang==idDonHang && trangThaiDonHangKT.idTrangThai == idTrangThai) || (trangThaiDonHangKT.idDonHang == idDonHang && trangThaiDonHangKT.idTrangThai == 5))
                {
                    kiemTraTrangThaiDonHang = true;
                }
            }

            if (kiemTraTrangThaiDonHang == false)
            {
                _context.Add(trangThaiDonHang);
                _context.SaveChanges();
            }

            if (idTrangThai == 5)
            {
                var danhSachChiTietDonHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
                foreach(var chiTietDonHang in danhSachChiTietDonHang)
                {
                    var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                    sach.soLuong = sach.soLuong + chiTietDonHang.soLuong;

                    _context.Update(sach);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction(nameof(thongKeDonHang));
        }

        public IActionResult huyDonHang(int idDonHang)
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            var trangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            var maxTrangThaiDonHang = trangThaiDonHang.Max(i => i.idTrangThai);

            if(maxTrangThaiDonHang == 5)
            {
                return RedirectToAction(nameof(hienThiDanhSachDonHang));
            }
            else
            {
                TrangThaiDonHang trangThaiDonHangHuy = new TrangThaiDonHang();
                trangThaiDonHangHuy.idDonHang = idDonHang;
                trangThaiDonHangHuy.idTrangThai = 5;
                trangThaiDonHangHuy.thoiGian = DateTime.Now;
                trangThaiDonHangHuy.idNhanVien = 0;

                _context.Add(trangThaiDonHangHuy);
                _context.SaveChanges();

                var danhSachChiTietDonHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();

                foreach (var chiTietDonHang in danhSachChiTietDonHang)
                {
                    var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                    sach.soLuong = sach.soLuong + chiTietDonHang.soLuong;

                    _context.Update(sach);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction(nameof(hienThiDanhSachDonHang));
        }
    }
}
