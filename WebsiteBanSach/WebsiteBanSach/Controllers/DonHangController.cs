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
using Microsoft.AspNetCore.Http;

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
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idKhachHang")))
            {
                return View("../taikhoankhachhang/dangnhap");
            }

            int idKhachHang = Int32.Parse(HttpContext.Session.GetString("idKhachHang"));

            List<DonHangVaTrangThai> danhSachDonHangVaTrangThai = new List<DonHangVaTrangThai>();
            var danhSachDonHang = _context.TapHopDonHang.Where(i => i.idKhachHang == idKhachHang).OrderByDescending(k => k.idDonHang).ToList();
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
            return View("HienThiDanhSachDonHang", danhSachDonHangVaTrangThai);
        }

        public IActionResult thongKeDonHang(int idDonHang, int idTrangThaiDonHang,
            string thuTuSapXep, int soTrang)
        {
            if (HttpContext.Session.GetString("idNhanVien") == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            List<DonHangVaTrangThai> danhSachDonHangVaTrangThai = new List<DonHangVaTrangThai>();
            List<DonHang> danhSachDonHangLoc = new List<DonHang>();
            var danhSachDonHang = _context.TapHopDonHang.OrderByDescending(i => i.idDonHang).ToList();
            var danhSachTrangThai = _context.TapHopTrangThai.ToList();

            if (idDonHang != 0)
            {
                danhSachDonHangLoc = danhSachDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            }
            else if (idTrangThaiDonHang != 0)
            {
                foreach (DonHang donHang in danhSachDonHang)
                {
                    var danhSachTrangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == donHang.idDonHang);
                    var trangThaiDonHang = danhSachTrangThaiDonHang.Max(i => i.idTrangThai);

                    if (idTrangThaiDonHang != 0 && idTrangThaiDonHang == trangThaiDonHang)
                    {
                        danhSachDonHangLoc.Add(donHang);
                    }
                }
            }
            else
            {
                danhSachDonHangLoc = danhSachDonHang;
            }
            
            foreach(DonHang donHang in danhSachDonHangLoc) {

                var danhSachTrangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == donHang.idDonHang);
                var trangThaiDonHang = danhSachTrangThaiDonHang.Max(i => i.idTrangThai);
                var stringTrangThaiDonHang = _context.TapHopTrangThai.Where(i => i.idTrangThai == trangThaiDonHang).FirstOrDefault();

                DonHangVaTrangThai donHangVaTrangThai = new DonHangVaTrangThai();
                donHangVaTrangThai.donHang= donHang;
                donHangVaTrangThai.trangThaiDonhang = stringTrangThaiDonHang.kieuTrangThai;

                danhSachDonHangVaTrangThai.Add(donHangVaTrangThai);
            }
            return View("ThongKeDonHang", danhSachDonHangVaTrangThai);
        }

        [HttpGet]
        public IActionResult xemDonHang(int? idDonHang)
        {
            if (HttpContext.Session.GetString("idKhachHang") == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            int idKhachHang = Int32.Parse(HttpContext.Session.GetString("idKhachHang"));

            var donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang & i.idKhachHang==idKhachHang).FirstOrDefault();

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
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idKhachHang")))
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("gioHang")))
            {
                return Redirect("../GioHang/xemGioHang");
            }

            List<ThanhPhanGioHang> gioHang = new List<ThanhPhanGioHang>();

            string[] mangIdSachVaSoLuong = HttpContext.Session.GetString("gioHang").Split(";");

            foreach(string idSachVaSoLuong in mangIdSachVaSoLuong)
            {
                string[] thongTin = idSachVaSoLuong.Split("-");
                int idSach = Int32.Parse(thongTin[0]);
                int soLuong = Int32.Parse(thongTin[1]);

                var sach = _context.TapHopSach.Where(s => s.idSach == idSach)
                            .Include(n => n.nhaXuatBan)
                            .Include(l => l.loaiSach)
                            .FirstOrDefault();

                ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();
                thanhPhanGioHang.sach = sach;
                thanhPhanGioHang.soLuong = soLuong;

                gioHang.Add(thanhPhanGioHang);
            }

            return View("./datHang", gioHang);
        }

        [HttpPost]
        public IActionResult datHang(string tenNguoiNhan, string diaChiGiaoHang, string soDienThoai)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("gioHang")))
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }
            DonHang donHang = new DonHang();
            donHang.idKhachHang = Int32.Parse(HttpContext.Session.GetString("idKhachHang"));
            donHang.tenNguoiNhan = tenNguoiNhan;
            donHang.diaChiGiaoHang = diaChiGiaoHang;
            donHang.soDienThoai = soDienThoai;
            donHang.thoiGianDatHang = DateTime.Now;
            decimal tongTien = 0;

            foreach (string thanhPhanGioHang in HttpContext.Session.GetString("gioHang").Split(";"))
            {
                string[] thongTin = thanhPhanGioHang.Split("-");
                int idSach = Int32.Parse(thongTin[0]);
                int soLuong = Int32.Parse(thongTin[1]);

                var sach = _context.TapHopSach.Where(s => s.idSach == idSach).FirstOrDefault();

                tongTien = tongTien + sach.giaBan * soLuong;
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

            foreach (string thanhPhanGioHangString in HttpContext.Session.GetString("gioHang").Split(";"))
            {
                string[] thongTin = thanhPhanGioHangString.Split("-");
                int idSach = Int32.Parse(thongTin[0]);
                int soLuong = Int32.Parse(thongTin[1]);

                var sach = _context.TapHopSach.Where(s => s.idSach == idSach).FirstOrDefault();
                ChiTietDonHang chiTietDonHang = new ChiTietDonHang();
                chiTietDonHang.idDonHang = _context.TapHopDonHang.Max(i => i.idDonHang);
                chiTietDonHang.idSach = idSach;
                chiTietDonHang.soLuong = soLuong;
                chiTietDonHang.giaBan = sach.giaBan;

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
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idKhachHang")))
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            var donHang = _context.TapHopDonHang.Find(idDonHang);
            if(donHang == null || donHang.idKhachHang != Int32.Parse(HttpContext.Session.GetString("idKhachHang")))
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
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var donHang = _context.TapHopDonHang.Where(i => i.idDonHang == idDonHang).FirstOrDefault();
            var gioHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            var trangThai = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == idDonHang).Max(t => t.idTrangThai);
            var stringTrangThai = _context.TapHopTrangThai.Where(i => i.idTrangThai == trangThai).FirstOrDefault().kieuTrangThai;

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
            trangThaiDonHang.idNhanVien = Int32.Parse(HttpContext.Session.GetString("idNhanVien"));
            trangThaiDonHang.idTrangThai = idTrangThai;

            bool kiemTraTrangThaiDonHang = false;

            foreach(TrangThaiDonHang trangThaiDonHangKT in _context.TapHopTrangThaiDonHang.ToList())
            {

                if((trangThaiDonHangKT.idDonHang==idDonHang && trangThaiDonHangKT.idTrangThai == idTrangThai) || (trangThaiDonHangKT.idDonHang == idDonHang && trangThaiDonHangKT.idTrangThai == 5)
                    || (trangThaiDonHangKT.idDonHang == idDonHang && trangThaiDonHangKT.idTrangThai == 4))
                {
                    kiemTraTrangThaiDonHang = true;
                }
            }

            if (kiemTraTrangThaiDonHang == false)
            {
                _context.Add(trangThaiDonHang);
                _context.SaveChanges();

                if (idTrangThai == 5)
                {
                    var danhSachChiTietDonHang = _context.TapHopChiTietDonHang.Where(i => i.idDonHang == idDonHang).ToList();
                    foreach (var chiTietDonHang in danhSachChiTietDonHang)
                    {
                        var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                        sach.soLuong = sach.soLuong + chiTietDonHang.soLuong;

                        _context.Update(sach);
                        _context.SaveChanges();
                    }
                }
                else if (idTrangThai == 4)
                {
                    var khachHang = _context.TapHopTaiKhoanKhachHang.Where(k => k.idKhachHang == donHang.idKhachHang).FirstOrDefault();
                    decimal tongTien = donHang.tongTien;
                    int diem = (int)tongTien / 100000;
                    khachHang.diemMuaHang = khachHang.diemMuaHang + diem;

                    _context.Update(khachHang);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction(nameof(thongKeDonHang));
        }

        public IActionResult huyDonHang(int idDonHang)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idKhachHang")))
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            var trangThaiDonHang = _context.TapHopTrangThaiDonHang.Where(i => i.idDonHang == idDonHang).ToList();
            var maxTrangThaiDonHang = trangThaiDonHang.Max(i => i.idTrangThai);

            if(maxTrangThaiDonHang == 5 || maxTrangThaiDonHang == 4)
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
