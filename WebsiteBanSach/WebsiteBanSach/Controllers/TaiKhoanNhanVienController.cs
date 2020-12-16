using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanSach.Data;
using WebsiteBanSach.Models;
using WebsiteBanSach.Models.Helper;
using WebsiteBanSach.Models.ViewModel;

namespace WebsiteBanSach.Controllers
{
    public class TaiKhoanNhanVienController : Controller
    {
        private readonly WebBanSachContext _context;

        public TaiKhoanNhanVienController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult thongKeTaiKhoan(string tenNhanVienTimKiem, int? soTrang)
        {
            if (SessionNhanVien.taiKhoan == null || SessionNhanVien.taiKhoan.vaiTro!="quản lý")
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
            if (SessionNhanVien.taiKhoan == null || SessionNhanVien.taiKhoan.vaiTro != "quản lý")
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
                //taiKhoanNhanVien.matKhau = MaHoa.MaHoaMD5(taiKhoanNhanVien.matKhau);
                _context.Add(taiKhoanNhanVien);
                _context.SaveChanges();
                return RedirectToAction(nameof(dangNhap));
            }
            return View("ThemTaiKhoan");
        }


        public IActionResult suaThongTinCaNhan()
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }
            var taiKhoanNhanVien = _context.TapHopTaiKhoanNhanVien.Find(SessionNhanVien.taiKhoan.idNhanVien);
            return View("CapNhapThongTinCaNhan",taiKhoanNhanVien);
        }

        [HttpPost]
        public IActionResult suaThongTinCaNhan(int id, [Bind("idNhanVien,tenNhanVien,soDienThoai,vaiTro,matKhau,trangThai")] TaiKhoanNhanVien taiKhoanNhanVien)
        {
            

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
            if (SessionNhanVien.taiKhoan == null || SessionNhanVien.taiKhoan.vaiTro != "quản lý")
            {
                ViewData["thongBao"] = "Bạn phải đăng nhập tài khoản nhân viên cấp quản lý để sử dụng chức năng này";
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var taiKhoanNhanVien = _context.TapHopTaiKhoanNhanVien.Find(idNhanVien);
            return View("CapNhapTrangThaiNhanVien",taiKhoanNhanVien);
        }

        [HttpPost]
        public IActionResult suaTrangThaiTaiKhoan(TaiKhoanNhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Update(nhanVien);
                _context.SaveChanges();

            }
            return RedirectToAction(nameof(thongKeTaiKhoan));
        }

        [HttpGet]
        public IActionResult dangNhap()
        {
            return View("DangNhap");
        }

        [HttpPost]
        public IActionResult dangNhap(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            try
            {
                //string matKhauDangNhap = MaHoa.MaHoaMD5(taiKhoanDangNhap.matKhau);
                string matKhauDangNhap = taiKhoanDangNhap.matKhau;
                int maNhanVien = Int32.Parse(taiKhoanDangNhap.taiKhoan);
                var danhSachTaiKhoan = _context.TapHopTaiKhoanNhanVien.ToList();

                foreach (TaiKhoanNhanVien taiKhoanNhanVien in danhSachTaiKhoan)
                {
                    if (maNhanVien == taiKhoanNhanVien.idNhanVien && matKhauDangNhap == taiKhoanNhanVien.matKhau)
                    {
                        SessionKhachHang.taiKhoan = null;
                        SessionNhanVien.taiKhoan = taiKhoanNhanVien;
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

        private bool TaiKhoanNhanVienExists(int id)
        {
            return _context.TapHopTaiKhoanNhanVien.Any(e => e.idNhanVien == id);
        }
    }
}
