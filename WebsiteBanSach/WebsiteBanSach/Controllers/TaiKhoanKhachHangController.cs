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
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
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
            
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idKhachHang")))
            {
                return View("../TaiKhoanKhachHang/DangNhap");
            }

            int idKhachHang = Int32.Parse(HttpContext.Session.GetString("idKhachHang"));

            TaiKhoanKhachHang taiKhoan = _context.TapHopTaiKhoanKhachHang.Find(idKhachHang);
            TaiKhoanDangKiKhachHang taiKhoanCapNhap = new TaiKhoanDangKiKhachHang();
            taiKhoanCapNhap.taiKhoanKhachHang = taiKhoan;
            taiKhoanCapNhap.xacNhanMatKhau = "";

            if (!String.IsNullOrEmpty((string)TempData["ThongDiepSuaTaiKhoanLoi"]))
            {
                ViewData["ThongDiepSuaTaiKhoanLoi"] = TempData["ThongDiepSuaTaiKhoanLoi"];
            }

            return View("SuaThongTinCaNhan", taiKhoanCapNhap);
        }

        [HttpPost]
        public IActionResult suaThongTinCaNhanPost(TaiKhoanKhachHang taiKhoanKhachHang, string xacNhanMatKhau, string matKhauCu)
        {
            if (taiKhoanKhachHang.matKhau == xacNhanMatKhau)
            {
                if (String.IsNullOrEmpty(taiKhoanKhachHang.matKhau))
                {
                    string matKhau = matKhauCu;
                    taiKhoanKhachHang.matKhau = matKhau;

                    _context.Update(taiKhoanKhachHang);
                    _context.SaveChanges();
                }
                else
                {
                    taiKhoanKhachHang.matKhau = MaHoa.MaHoaMD5(taiKhoanKhachHang.matKhau);
                    _context.Update(taiKhoanKhachHang);
                    _context.SaveChanges();
                }
                
                return Redirect("../Sach/hienThiDanhSachSach");
            }
            else
            {
                TempData["ThongDiepSuaTaiKhoanLoi"] = "Mật khẩu và xác nhận mật khẩu không trùng khớp";
                return RedirectToAction(nameof(suaThongTinCaNhan));
            }       
        }

        [HttpGet]
        public IActionResult suaTrangThaiTaiKhoan(int? idKhachHang)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("idNhanVien")))
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
        public IActionResult xacNhanDangNhap(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            String matKhauDangNhap = MaHoa.MaHoaMD5(taiKhoanDangNhap.matKhau);
            var danhSachTaiKhoan = _context.TapHopTaiKhoanKhachHang.ToList();
            
            foreach(TaiKhoanKhachHang taiKhoanKhachHang in danhSachTaiKhoan)
            {
                if (taiKhoanDangNhap.taiKhoan == taiKhoanKhachHang.taiKhoan && matKhauDangNhap == taiKhoanKhachHang.matKhau && taiKhoanKhachHang.trangThai==true)
                {
                    //Response.Cookies.Append("name", taiKhoanKhachHang.tenKhachHang);

                    HttpContext.Session.SetString("idKhachHang", taiKhoanKhachHang.idKhachHang.ToString());
                    return Redirect("../Sach/hienThiDanhSachSach");
                }
            }
            ViewData["ThongDiepDangNhapLoi"] = "Tài khoản hoặc mật khẩu không đúng";
            return View("dangNhap");
        }

        public IActionResult dangXuat()
        {
            HttpContext.Session.Remove("idKhachHang");
            return RedirectToAction("dangNhap");
        }
    }
}
