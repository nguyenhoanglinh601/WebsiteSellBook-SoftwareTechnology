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
    public class NhaXuatBanController : Controller
    {
        private readonly WebBanSachContext _context;

        public NhaXuatBanController(WebBanSachContext context)
        {
            _context = context;
        }

        // GET: NhaXuatBan
        public async Task<IActionResult> ThongKeNhaXuatBan()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            return View(await _context.TapHopNhaXuatBan.ToListAsync());
        }

        // GET: NhaXuatBan/Details/5
        public async Task<IActionResult> ChiTietNhaXuatBan(int? id)
        { 

            if (id == null)
            {
                return NotFound();
            }

            var nhaXuatBan = await _context.TapHopNhaXuatBan
                .FirstOrDefaultAsync(m => m.idNhaXuatBan == id);
            if (nhaXuatBan == null)
            {
                return NotFound();
            }

            return View(nhaXuatBan);
        }
        
        [HttpGet]
        public IActionResult ThemNhaXuatBan()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemNhaXuatBan([Bind("idNhaXuatBan,ten,soDienThoai,diaChi,email,website")] NhaXuatBan nhaXuatBan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaXuatBan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ThongKeNhaXuatBan));
            }
            return View(nhaXuatBan);
        }

        [HttpGet]
        public async Task<IActionResult> SuaThongTinNXB(int? id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var nhaXuatBan = await _context.TapHopNhaXuatBan.FindAsync(id);
            if (nhaXuatBan == null)
            {
                return NotFound();
            }
            return View(nhaXuatBan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaThongTinNXB(int id, [Bind("idNhaXuatBan,ten,soDienThoai,diaChi,email,website")] NhaXuatBan nhaXuatBan)
        {
            if (id != nhaXuatBan.idNhaXuatBan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaXuatBan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaXuatBanExists(nhaXuatBan.idNhaXuatBan))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ThongKeNhaXuatBan));
            }
            return View(nhaXuatBan);
        }
        
        [HttpGet]
        public async Task<IActionResult> XoaNhaXuatBan(int? id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var nhaXuatBan = await _context.TapHopNhaXuatBan
                .FirstOrDefaultAsync(m => m.idNhaXuatBan == id);
            if (nhaXuatBan == null)
            {
                return NotFound();
            }

            return View(nhaXuatBan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> XoaNhaXuatBan(int id)
        {
            var nhaXuatBan = await _context.TapHopNhaXuatBan.FindAsync(id);
            _context.TapHopNhaXuatBan.Remove(nhaXuatBan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ThongKeNhaXuatBan));
        }

        private bool NhaXuatBanExists(int id)
        {
            return _context.TapHopNhaXuatBan.Any(e => e.idNhaXuatBan == id);
        }
    }
}
