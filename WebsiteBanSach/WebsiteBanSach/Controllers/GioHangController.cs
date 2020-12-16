using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanSach.Models.ViewModel;
using WebsiteBanSach.Models;
using WebsiteBanSach.Data;

namespace WebsiteBanSach.Controllers
{
    public class GioHangController : Controller
    {
        private readonly WebBanSachContext _context;

        public GioHangController(WebBanSachContext context)
        {
            _context = context;
        }

        public IActionResult themSachVaoGioHang(int idSach)
        {
            
            var tapHopSach = _context.TapHopSach.ToList();
            
            foreach (Sach sach in tapHopSach)
            {

                if (sach.idSach == idSach)
                {
                    
                    bool kiemTraGioHang = false;

                    if(SessionKhachHang.gioHang.tapHopSanPham != null)
                    {
                        foreach (ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
                        {

                            if (thanhPhanGioHang.sach.idSach == sach.idSach)
                            {
                                kiemTraGioHang = true;
                            }
                        }
                    }
                    
                    if (kiemTraGioHang == false)
                    {
                        ThanhPhanGioHang thanhPhanGioHangThem = new ThanhPhanGioHang();
                        thanhPhanGioHangThem.sach = sach;
                        thanhPhanGioHangThem.soLuong = 1;
                        SessionKhachHang.gioHang.tapHopSanPham.Add(thanhPhanGioHangThem);
                        
                    }
                    
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }

        public IActionResult xoaSachKhoiGioHang(int idSach)
        {
            foreach(ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
            {
                
                if (thanhPhanGioHang.sach.idSach == idSach)
                {
                    SessionKhachHang.gioHang.tapHopSanPham.Remove(thanhPhanGioHang);
                    return RedirectToAction(nameof(xemGioHang));
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }

        public IActionResult xemGioHang()
        {
            SessionKhachHang.gioHang.danhSachNXB = _context.TapHopNhaXuatBan.ToList();
            SessionKhachHang.gioHang.tapHopLoaiSach = _context.TapHopLoaiSach.ToList();
            return View("GioHang",SessionKhachHang.gioHang);
        }

        [HttpGet]
        public IActionResult suaGioHang(int idSach)
        {
            foreach(ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
            {
                if(thanhPhanGioHang.sach.idSach == idSach)
                {
                    thanhPhanGioHang.danhSachNXB = _context.TapHopNhaXuatBan.ToList();
                    thanhPhanGioHang.tapHopLoaiSach = _context.TapHopLoaiSach.ToList();
                    return View("./SuaGioHang", thanhPhanGioHang);
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }

        public IActionResult suaGioHang(int idSach, int soLuong)
        {
            //ViewData["idSach"] = idSach + " - " + soLuong ;
            //return View("../Debug");
            foreach (ThanhPhanGioHang thanhPhanGioHang in SessionKhachHang.gioHang.tapHopSanPham)
            {
                if (thanhPhanGioHang.sach.idSach == idSach)
                {
                    thanhPhanGioHang.soLuong = soLuong;
                    break;
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }
    }
}
