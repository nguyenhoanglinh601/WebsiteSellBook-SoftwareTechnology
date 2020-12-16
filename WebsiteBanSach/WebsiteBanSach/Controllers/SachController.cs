using System;
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

namespace WebsiteBanSach.Controllers
{
    public class SachController : Controller
    {
        private readonly WebBanSachContext _context;
        TaiKhoanKhachHang taiKhoanDangNhap = SessionKhachHang.taiKhoan;

        public SachController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult hienThiDanhSachSach(string tenSachTimKiem, string tenSachDangTimKiem,
            string tenLoai, string thuTuSapXep, int? soTrang)
        {
            var tapHopSach = _context.TapHopSach.ToList();

            if (!String.IsNullOrEmpty(tenSachTimKiem))
            {
                tapHopSach = tapHopSach.Where(s => s.ten.Contains(tenSachTimKiem)).ToList();
            }

            return View("HienThiDanhSachSach", tapHopSach);
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
            if (SessionNhanVien.taiKhoan == null)
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
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var tapHopLoaiSach = _context.TapHopLoaiSach.ToList();
            return View("ThongKeLoaiSach",tapHopLoaiSach);
        }

        [HttpGet]
        public IActionResult themSach()
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            SachNXBLoai thongTinSach = new SachNXBLoai();
            thongTinSach.danhSachNhaXuatBan = _context.TapHopNhaXuatBan.ToList();
            thongTinSach.danhSachLoai = _context.TapHopLoaiSach.ToList();
            return View("ThemSach", thongTinSach);
        }

        [HttpPost]
        public IActionResult themSach([Bind("idSach,lanTaiBan,ten,idNhaXuatBan,maLoai,giaBan,soLuong,moTa,hinhAnh,trangThai")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sach);
                _context.SaveChanges();
                return RedirectToAction(nameof(thongKeSach));
            }
            return View("ThemSach");
        }

        [HttpGet]
        public IActionResult themLoaiSach()
        {
            if (SessionNhanVien.taiKhoan == null)
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
            if (SessionNhanVien.taiKhoan == null)
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
            if (SessionNhanVien.taiKhoan == null)
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
            if (SessionNhanVien.taiKhoan == null)
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
