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
using Microsoft.AspNetCore.Session;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace WebsiteBanSach.Controllers
{
    public class TaiKhoanKhachHangController : Controller
    {
        private readonly WebBanSachContext _context;

        public TaiKhoanKhachHangController(WebBanSachContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult thongKeTaiKhoan(string tenKhachHangTimKiem, int? soTrang)
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            var danhSachTaiKhoanKhachHang = _context.TapHopTaiKhoanKhachHang.ToList();
            if (!String.IsNullOrEmpty(tenKhachHangTimKiem))
            {
                danhSachTaiKhoanKhachHang = danhSachTaiKhoanKhachHang.Where(t => t.tenKhachHang.Contains(tenKhachHangTimKiem)).ToList();
            }
               
            return View("ThongKeTaiKhoan",danhSachTaiKhoanKhachHang);
        }

        [HttpGet]
        public IActionResult dangKi()
        {
            return View("DangKi");
        }

        [HttpPost]
        public IActionResult xacNhanDangKi(TaiKhoanDangKiKhachHang taiKhoanDangKi)
        {
            string taiKhoan = taiKhoanDangKi.taiKhoanKhachHang.taiKhoan;
            var danhSachTaiKhoan = _context.TapHopTaiKhoanKhachHang.ToList();

            foreach(TaiKhoanKhachHang taiKhoanKhachHang in danhSachTaiKhoan){
                if (taiKhoanKhachHang.taiKhoan == taiKhoan)
                {
                    ViewData["ThongDiepLoiDangKi"] = "Tên đăng nhập đã tồn tại";
                    return View("DangKi");
                }
            }

            if (taiKhoanDangKi.taiKhoanKhachHang.matKhau != taiKhoanDangKi.xacNhanMatKhau)
            {
                ViewData["ThongDiepThemTaiKhoanLoi"] = "Mật khẩu và xác nhận mật khẩu không trùng khớp";
                return View("DangKi");
            }

            //if (KiemTra.kiemTraSDT(taiKhoanDangKi.taiKhoanKhachHang.soDienThoai) == false)
            //{
            //    ViewData["ThongDiepLoiDangKi"] = "Số điện thoại không hợp lệ";
            //    return View("DangKi");
            //}

            taiKhoanDangKi.taiKhoanKhachHang.trangThai = true;
            taiKhoanDangKi.taiKhoanKhachHang.matKhau = MaHoa.MaHoaMD5(taiKhoanDangKi.taiKhoanKhachHang.matKhau);
            _context.Add(taiKhoanDangKi.taiKhoanKhachHang);
            _context.SaveChanges();

            return Redirect("dangNhap");
        }

        [HttpGet]
        public IActionResult suaThongTinCaNhan()
        {
            if (SessionKhachHang.taiKhoan == null)
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            TaiKhoanKhachHang taiKhoan = _context.TapHopTaiKhoanKhachHang.Find(SessionKhachHang.taiKhoan.idKhachHang);
            TaiKhoanDangKiKhachHang taiKhoanCapNhap = new TaiKhoanDangKiKhachHang();
            taiKhoanCapNhap.taiKhoanKhachHang = taiKhoan;
            taiKhoanCapNhap.xacNhanMatKhau = taiKhoan.matKhau;

            return View("SuaThongTinCaNhan", taiKhoanCapNhap);
        }

        [HttpPost]
        public IActionResult suaThongTinCaNhan(TaiKhoanKhachHang taiKhoanKhachHang, string xacNhanMatKhau)
        {
            if (taiKhoanKhachHang.matKhau == xacNhanMatKhau)
            {
                taiKhoanKhachHang.matKhau = MaHoa.MaHoaMD5(taiKhoanKhachHang.matKhau);
                Console.WriteLine(taiKhoanKhachHang.matKhau);
                _context.Update(taiKhoanKhachHang);
                _context.SaveChanges();
                return View("../Sach/hienThiDanhSachSach");
            }
            else
            {
                ViewData["ThongDiepSuaTaiKhoanLoi"] = "Mật khẩu và xác nhận mật khẩu không trùng khớp";
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult suaTrangThaiTaiKhoan(int? idKhachHang)
        {
            if (SessionNhanVien.taiKhoan == null)
            {
                return View("../TaiKhoanNhanVien/DangNhap");
            }

            if (idKhachHang == null)
            {
                return NotFound();
            }

            var taiKhoanKhachHang = _context.TapHopTaiKhoanKhachHang.Find(idKhachHang);
            if (taiKhoanKhachHang == null)
            {
                return NotFound();
            }
            return View(taiKhoanKhachHang);
        }

        [HttpPost]
        public IActionResult suaTrangThaiTaiKhoan([Bind("idKhachHang,tenKhachHang,ngaySinh,gioiTinh,soDienThoai,diaChi,diemMuaHang,taiKhoan,matKhau,trangThai")] TaiKhoanKhachHang taiKhoanKhachHang)
        { 

            if (ModelState.IsValid)
            {
                    _context.Update(taiKhoanKhachHang);
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
        public IActionResult xacNhanDangNhap(object sender, TaiKhoanDangNhap taiKhoanDangNhap)
        {
            String matKhauDangNhap = MaHoa.MaHoaMD5(taiKhoanDangNhap.matKhau);
            var danhSachTaiKhoan = _context.TapHopTaiKhoanKhachHang.ToList();
            
            foreach(TaiKhoanKhachHang taiKhoanKhachHang in danhSachTaiKhoan)
            {
                if (taiKhoanDangNhap.taiKhoan == taiKhoanKhachHang.taiKhoan && matKhauDangNhap == taiKhoanKhachHang.matKhau)
                {
                    SessionKhachHang.taiKhoan = taiKhoanKhachHang;
                    SessionNhanVien.taiKhoan = null;
                    ViewData["ThongDiepDangNhapLoi"] = "";
                    return Redirect("../Sach/hienThiDanhSachSach");
                }
            }
            ViewData["ThongDiepDangNhapLoi"] = "Tài khoản hoặc mật khẩu không đúng";
            return View("dangNhap");
        }
    }
}
