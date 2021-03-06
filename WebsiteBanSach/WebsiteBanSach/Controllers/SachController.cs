﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanSach.Data;
using WebsiteBanSach.Models;
using WebsiteBanSach.Models.ViewModel;
using WebsiteBanSach.Models.Helper;

namespace WebsiteBanSach.Controllers
{
    public class SachController : Controller
    {
        private readonly WebBanSachContext _context;

        public SachController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult hienThiDanhSachSach(string tenSachTimKiem, string tenSachDangTimKiem,
            string tenLoai, string thuTuSapXep, int? soTrang, string locSach)
        {
            ViewData["CurrentSort"] = thuTuSapXep;
            if (tenSachTimKiem != null)
            {
                soTrang = 1;
            }
            else
            {
                tenSachTimKiem = tenSachDangTimKiem;
            }
            var tapHopSach = _context.TapHopSach.Where(t => t.trangThai==true);

            if (String.IsNullOrEmpty(locSach))
            {
                if (String.IsNullOrEmpty(HttpContext.Session.GetString("locSach")))
                {
                    HttpContext.Session.SetString("locSach", "all");
                }
            }
            else
            {
                HttpContext.Session.SetString("locSach", locSach);
            }

            locSach = HttpContext.Session.GetString("locSach");
            switch (locSach.Split("$")[0])
            {
                case "sach-ban-chay":
                    tapHopSach = sachBanChay(tapHopSach.ToList());
                    break;
                case "sach-giam-gia":
                    tapHopSach = sachGiamGia(tapHopSach.ToList());
                    break;
                case "tinh-cam":
                case "Tình cảm":
                    tapHopSach = loaiSach(tapHopSach.ToList(), "tình cảm");
                    break;
                case "khoa-hoc":
                case "Khoa học":
                    tapHopSach = loaiSach(tapHopSach.ToList(), "khoa học");
                    break;
                case "trinh-tham":
                case "Trinh thám":
                    tapHopSach = loaiSach(tapHopSach.ToList(), "trinh thám");
                    break;
                case "nxb":
                    tapHopSach = nhaXuatBan(tapHopSach.ToList(), locSach.Split("$")[1]);
                    break;
                default:
                    break;
            }

            if (!String.IsNullOrEmpty(tenSachTimKiem))
            {
                tapHopSach = tapHopSach.Where(s => s.ten.Contains(tenSachTimKiem));
            }

            int pageSize = 12;
            return View(PaginatedList<Sach>.CreateAsync(tapHopSach, soTrang ?? 1, pageSize));
        }

        private IQueryable<Sach> sachBanChay(List<Sach> tapHopSach)
        {
            List<ThanhPhanGioHang> danhSachSachDaBan = new List<ThanhPhanGioHang>();
            var danhSachChiTietDonHang = _context.TapHopChiTietDonHang.ToList();

            foreach(var chiTietDonHang in danhSachChiTietDonHang)
            {
                bool kiemTra = false;
                if(danhSachSachDaBan !=null && !danhSachSachDaBan.Any())
                {
                    foreach (var sachDaBan in danhSachSachDaBan)
                    {
                        if (sachDaBan.sach.idSach == chiTietDonHang.idSach)
                        {
                            sachDaBan.soLuong = sachDaBan.soLuong + chiTietDonHang.soLuong;
                            kiemTra = true;
                        }
                    }
                }
                
                if (kiemTra == false)
                {
                    ThanhPhanGioHang sachDaBan = new ThanhPhanGioHang();
                    var sach = _context.TapHopSach.Where(i => i.idSach == chiTietDonHang.idSach).FirstOrDefault();
                    sachDaBan.sach = sach;
                    sachDaBan.soLuong = chiTietDonHang.soLuong;

                    danhSachSachDaBan.Add(sachDaBan);
                }
            }

            danhSachSachDaBan = danhSachSachDaBan.OrderByDescending(i => i.soLuong).ToList();

            List<Sach> danhSachSachBanChay = new List<Sach>();
            foreach(var sachDaBan in danhSachSachDaBan)
            {
                danhSachSachBanChay.Add(sachDaBan.sach);
            }

            return danhSachSachBanChay.AsQueryable();
        }

        private IQueryable<Sach> sachGiamGia(List<Sach> tapHopSach)
        {
            var tapHopChiTietDonHang = _context.TapHopChiTietDonHang.ToList();
            List<Sach> tapHopSachGiamGia = new List<Sach>();

            foreach(var sach in tapHopSach)
            {
                foreach(var chiTietDonHang in tapHopChiTietDonHang)
                {
                    if(sach.idSach==chiTietDonHang.idSach && sach.giaBan < chiTietDonHang.giaBan)
                    {
                        tapHopSachGiamGia.Add(sach);
                    }
                }
            }

            return tapHopSachGiamGia.AsQueryable();
        }

        private IQueryable<Sach> loaiSach(List<Sach> tapHopSach, string loaiSach)
        {
            List<Sach> tapHopSachLoc = new List<Sach>();
            int maLoai = _context.TapHopLoaiSach.Where(i => i.tenLoai == loaiSach).Select(i => i.idLoai).FirstOrDefault();
            foreach(var sach in tapHopSach)
            {
                if (sach.maLoai == maLoai)
                {
                    tapHopSachLoc.Add(sach);
                }
            }
            return tapHopSachLoc.AsQueryable();
        }

        private IQueryable<Sach> nhaXuatBan(List<Sach> tapHopSach, string id)
        {
            int idNXB = Int32.Parse(id);
            List<Sach> tapHopSachLoc = new List<Sach>();
            foreach(var sach in tapHopSach)
            {
                if (sach.idNhaXuatBan == idNXB)
                {
                    tapHopSachLoc.Add(sach);
                }
            }

            return tapHopSachLoc.AsQueryable();
        }

        public IActionResult xemThongTinSach(int? idSach, int? lanTaiBan)
        {
            ThongTinSach thongTinSach = new ThongTinSach();
            var sach = _context.TapHopSach.Find(idSach, lanTaiBan);
            var NXB = _context.TapHopNhaXuatBan.Find(sach.idNhaXuatBan);
            var loaiSach = _context.TapHopLoaiSach.Find(sach.maLoai);
            thongTinSach.sach = sach;
            thongTinSach.NXB = NXB.ten;
            thongTinSach.loaiSach = loaiSach.tenLoai;
            return View("XemThongTinSach", thongTinSach);
        }

        public IActionResult thongKeSach(string tenSachTimKiem)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var tapHopSach = _context.TapHopSach.ToList();
            var danhSachNhaXuatBan = _context.TapHopNhaXuatBan.ToList();
            var tapHopLoaiSach = _context.TapHopLoaiSach.ToList();
            ThongKeSach thongKeSach = new ThongKeSach();
            thongKeSach.tapHopSach = tapHopSach;
            thongKeSach.danhSachNXB = danhSachNhaXuatBan;
            thongKeSach.tapHopLoaiSach = tapHopLoaiSach;
            return View(thongKeSach);
        }

        public IActionResult thongKeLoaiSach()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var tapHopLoaiSach = _context.TapHopLoaiSach.ToList();
            return View("ThongKeLoaiSach",tapHopLoaiSach);
        }

        [HttpGet]
        public IActionResult themSach()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            SachNXBLoai thongTinSach = new SachNXBLoai();
            thongTinSach.danhSachNhaXuatBan = _context.TapHopNhaXuatBan.ToList();
            thongTinSach.danhSachLoai = _context.TapHopLoaiSach.ToList();
            return View("ThemSach", thongTinSach);
        }

        [HttpPost]
        public IActionResult themSach([Bind("idSach,lanTaiBan,ten,idNhaXuatBan,maLoai,giaBan,soLuong,moTa,hinhAnh,trangThai,nhaXuatBan,loaiSach")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                sach.loaiSach = _context.TapHopLoaiSach.Where(l => l.idLoai == sach.maLoai).FirstOrDefault();
                sach.nhaXuatBan = _context.TapHopNhaXuatBan.Where(n => n.idNhaXuatBan == sach.idNhaXuatBan).FirstOrDefault();
                _context.Add(sach);
                _context.SaveChanges();
                return RedirectToAction(nameof(thongKeSach));
            }
            return View("ThemSach");
        }

        [HttpGet]
        public IActionResult themLoaiSach()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            return View("ThemLoaiSach");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> themLoaiSach([Bind("idLoai,tenLoai,moTa")] LoaiSach loaiSach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiSach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(thongKeSach));
            }
            return RedirectToAction(nameof(themLoaiSach));
        }

        [HttpGet]
        public async Task<IActionResult> suaThongTinSach(int? id, int? lanTaiBan)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var sach = await _context.TapHopSach.FindAsync(id,lanTaiBan);
            var danhSachNXB = _context.TapHopNhaXuatBan.ToList();
            var danhSachLoai = _context.TapHopLoaiSach.ToList();

            SachNXBLoai thongTinSach = new SachNXBLoai();

            thongTinSach.sach = sach;
            thongTinSach.danhSachNhaXuatBan = danhSachNXB;
            thongTinSach.danhSachLoai = danhSachLoai;

            if (sach == null)
            {
                return NotFound();
            }
            return View("suaThongTinSach", thongTinSach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> suaThongTinSach(int id, [Bind("idSach,lanTaiBan,ten,idNhaXuatBan,maLoai,giaBan,soLuong,moTa,hinhAnh,trangThai")] Sach sach)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SachExists(sach.idSach))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(thongKeSach));
            }
            return View();
        }

        [HttpGet]
        public IActionResult suaLoaiSach()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }
            return View();
        }

        [HttpPost]
        public IActionResult suaLoaiSach(int idLoaiSach, LoaiSach loaiSach)
        {
            return View();
        }

        [HttpGet]
        public IActionResult themTacGiaSach()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            ViewData["idTacGia"] = new SelectList(_context.TapHopTacGia, "idTacGia", "idTacGia");
            SachTacGia sachTacGia = new SachTacGia();
            sachTacGia.sach = _context.TapHopSach.ToList();
            sachTacGia.tacGia = _context.TapHopTacGia.ToList();
            return View("ThemTacGiaSach", sachTacGia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> themTacGiaSach([Bind("idSach,idTacGia")] ChiTietSach chiTietSach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietSach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(thongKeSach));
            }
            ViewData["idTacGia"] = new SelectList(_context.TapHopTacGia, "idTacGia", "idTacGia", chiTietSach.idTacGia);
            return RedirectToAction(nameof(themTacGiaSach));
        }

        private bool SachExists(int id)
        {
            return _context.TapHopSach.Any(e => e.idSach == id);
        }
    }
}
