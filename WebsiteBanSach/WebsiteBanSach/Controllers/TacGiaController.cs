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
    public class TacGiaController : Controller
    {
        private readonly WebBanSachContext _context;

        public TacGiaController(WebBanSachContext context)
        {
            _context = context;
        }

        // GET: TacGia
        public async Task<IActionResult> ThongKeTacGia()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }
            return View(await _context.TapHopTacGia.ToListAsync());
        }

        // GET: TacGia/Details/5
        public async Task<IActionResult> ChiTietTacGia(int? id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var tacGia = await _context.TapHopTacGia
                .FirstOrDefaultAsync(m => m.idTacGia == id);
            if (tacGia == null)
            {
                return NotFound();
            }

            return View(tacGia);
        }
        public async Task<IActionResult> xemTacGia(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tacGia = await _context.TapHopTacGia
                .FirstOrDefaultAsync(m => m.idTacGia == id);
            if (tacGia == null)
            {
                return NotFound();
            }

            return View(tacGia);
        }

        // GET: TacGia/Create
        public IActionResult ThemTacGia()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            return View();
        }

        // POST: TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemTacGia([Bind("idTacGia,ten,gioiTinh,namSinh,quocTich")] TacGia tacGia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tacGia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ThongKeTacGia));
            }
            return View(tacGia);
        }

        // GET: TacGia/Edit/5
        public async Task<IActionResult> SuaTacGia(int? id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var tacGia = await _context.TapHopTacGia.FindAsync(id);
            if (tacGia == null)
            {
                return NotFound();
            }
            return View(tacGia);
        }

        // POST: TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaTacGia(int id, [Bind("idTacGia,ten,gioiTinh,namSinh,quocTich")] TacGia tacGia)
        {
            if (id != tacGia.idTacGia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tacGia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TacGiaExists(tacGia.idTacGia))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ThongKeTacGia));
            }
            return View(tacGia);
        }

        // GET: TacGia/Delete/5
        public async Task<IActionResult> XoaTacGia(int? id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (id == null)
            {
                return NotFound();
            }

            var tacGia = await _context.TapHopTacGia
                .FirstOrDefaultAsync(m => m.idTacGia == id);
            if (tacGia == null)
            {
                return NotFound();
            }

            return View(tacGia);
        }

        // POST: TacGia/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> XoaTacGia(int id)
        {
            var tacGia = await _context.TapHopTacGia.FindAsync(id);
            _context.TapHopTacGia.Remove(tacGia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ThongKeTacGia));
        }

        private bool TacGiaExists(int id)
        {
            return _context.TapHopTacGia.Any(e => e.idTacGia == id);
        }
    }
}
