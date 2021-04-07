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
using WebsiteBanSach.Models.Helper;
using WebsiteBanSach.Models.ViewModel;
using Microsoft.AspNetCore.Http;

namespace WebsiteBanSach.Controllers
{
    [Route("admin/[action]")]
    public class TaiKhoanNhanVienController : Controller
    {
        private readonly WebBanSachContext _context;

        public TaiKhoanNhanVienController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult thongKeTaiKhoan(string tenNhanVienTimKiem, int? soTrang)
        {

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")) || HttpContext.Session.GetString("vaiTroNV")!="quản lý")
            {
                ViewData["thongBao"] = "Bạn phải đăng nhập tài khoản nhân viên cấp quản lý để sử dụng chức năng này";
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var danhSachTaiKhoanNhanVien = _context.TapHopTaiKhoanNhanVien.ToList();
            if (!String.IsNullOrEmpty(tenNhanVienTimKiem))
            {
                danhSachTaiKhoanNhanVien = danhSachTaiKhoanNhanVien.Where(t => t.tenNhanVien.Contains(tenNhanVienTimKiem)).ToList();
            }

            return View("ThongKeTaiKhoan", danhSachTaiKhoanNhanVien);
        }

        [HttpGet]
        public IActionResult themTaiKhoan()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")) || HttpContext.Session.GetString("vaiTroNV") != "quản lý")
            {
                ViewData["thongBao"] = "Bạn phải đăng nhập tài khoản nhân viên cấp quản lý để sử dụng chức năng này";
                return View("../TaiKhoanNhanVien/DangNhap");
            }
            return View("ThemTaiKhoan");
        }

        [HttpPost]
        public IActionResult themTaiKhoan([Bind("idNhanVien,tenNhanVien,soDienThoai,vaiTro,matKhau,trangThai")] TaiKhoanNhanVien taiKhoanNhanVien, string xacNhanMatKhau)
        {
            if(taiKhoanNhanVien.matKhau != xacNhanMatKhau)
            {
                ViewData["ThongDiepDangKiLoi"]="Mật khẩu và xác nhận mật khẩu không trùng khớp";
            }
            else if (ModelState.IsValid)
            {
                taiKhoanNhanVien.matKhau = MaHoa.MaHoaMD5(taiKhoanNhanVien.matKhau);
                _context.Add(taiKhoanNhanVien);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("ThemTaiKhoan");
        }

        [HttpGet]
        public IActionResult suaThongTinCaNhan()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (!String.IsNullOrEmpty((string)TempData["thongBao"]))
            {
                ViewData["thongBao"] = TempData["thongBao"];
            }
            var taiKhoanNhanVien = _context.TapHopTaiKhoanNhanVien.Find(Int32.Parse(HttpContext.Session.GetString("idNhanVien")));
            return View("CapNhapThongTinCaNhan",taiKhoanNhanVien);
        }

        [HttpPost]
        public IActionResult suaThongTinCaNhanPost(int id, [Bind("idNhanVien,tenNhanVien,soDienThoai,vaiTro,matKhau,trangThai")] TaiKhoanNhanVien taiKhoanNhanVien, string matKhauCu, string xacNhanMatKhau)
        {
            if (String.IsNullOrEmpty(taiKhoanNhanVien.matKhau))
            {
                taiKhoanNhanVien.matKhau = matKhauCu;
            }
            else
            {
                if (taiKhoanNhanVien.matKhau != xacNhanMatKhau)
                {
                    TempData["thongBao"] = "Mật khẩu và xác nhận mật khẩu không trùng khớp";
                    return RedirectToAction("suaThongTinCaNhan");
                }
                else
                {
                    taiKhoanNhanVien.matKhau = MaHoa.MaHoaMD5(taiKhoanNhanVien.matKhau);
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    taiKhoanNhanVien.trangThai = true;
                    _context.Update(taiKhoanNhanVien);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanNhanVienExists(taiKhoanNhanVien.idNhanVien))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("../DonHang/thongkedonhang");
            }
            return View("CapNhapThongTinCaNhan", taiKhoanNhanVien);
        }

        [HttpGet]
        public IActionResult suaTrangThaiTaiKhoan(int? idNhanVien)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")) || HttpContext.Session.GetString("vaiTroNV") != "quản lý")
            {
                ViewData["thongBao"] = "Bạn phải đăng nhập tài khoản nhân viên cấp quản lý để sử dụng chức năng này";
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (!String.IsNullOrEmpty((string)TempData["thongBao"]))
            {
                ViewData["thongBao"] = TempData["thongBao"];
            }
            var taiKhoanNhanVien = _context.TapHopTaiKhoanNhanVien.Find(idNhanVien);
            return View("CapNhapTrangThaiNhanVien",taiKhoanNhanVien);
        }

        [HttpPost]
        public IActionResult suaTrangThaiTaiKhoan(TaiKhoanNhanVien nhanVien, string matKhauCu, string xacNhanMatKhau)
        {
            if (String.IsNullOrEmpty(nhanVien.matKhau))
            {
                nhanVien.matKhau = matKhauCu;
            }
            else
            {
                if (nhanVien.matKhau != xacNhanMatKhau)
                {
                    TempData["thongBao"] = "Mật khẩu và xác nhận mật khẩu không trùng khớp";
                    return RedirectToAction("suaTrangThaiTaiKhoan", new { idNhanVien = nhanVien.idNhanVien }); ;
                }
                else
                {
                    nhanVien.matKhau = MaHoa.MaHoaMD5(nhanVien.matKhau);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Update(nhanVien);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(thongKeTaiKhoan));
        }

        [HttpGet]
        [ActionName("Index")]
        public IActionResult dangNhap()
        {
            return View("DangNhap");
        }

        [HttpPost]
        public IActionResult dangNhap(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            try
            {
                string matKhauDangNhap = MaHoa.MaHoaMD5(taiKhoanDangNhap.matKhau);
                //string matKhauDangNhap = taiKhoanDangNhap.matKhau;
                int maNhanVien = Int32.Parse(taiKhoanDangNhap.taiKhoan);
                var danhSachTaiKhoan = _context.TapHopTaiKhoanNhanVien.ToList();

                foreach (TaiKhoanNhanVien taiKhoanNhanVien in danhSachTaiKhoan)
                {
                    if (maNhanVien == taiKhoanNhanVien.idNhanVien && matKhauDangNhap == taiKhoanNhanVien.matKhau && taiKhoanNhanVien.trangThai==true)
                    {
                        HttpContext.Session.SetString("idNhanVien", taiKhoanNhanVien.idNhanVien.ToString());
                        HttpContext.Session.SetString("vaiTroNV", taiKhoanNhanVien.vaiTro);
                        return Redirect("../DonHang/ThongKeDonHang");
                    }
                }
                ViewData["ThongDiepDangNhapLoi"] = "Tài khoản hoặc mật khẩu không đúng";
                return View("dangNhap");
            }
            catch
            {
                return View("dangNhap");
            }
        }

        public IActionResult dangXuat()
        {
            HttpContext.Session.Remove("idNhanVien");
            return View("./DangNhap");
        }

        private bool TaiKhoanNhanVienExists(int id)
        {
            return _context.TapHopTaiKhoanNhanVien.Any(e => e.idNhanVien == id);
        }
    }
}
