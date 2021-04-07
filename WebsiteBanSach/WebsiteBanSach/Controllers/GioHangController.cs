using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanSach.Models.ViewModel;
using WebsiteBanSach.Models;
using WebsiteBanSach.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

                    if(!String.IsNullOrEmpty(HttpContext.Session.GetString("gioHang")))
                    {
                        string sessionGioHang = HttpContext.Session.GetString("gioHang");
                        foreach (string thanhPhanGioHang in sessionGioHang.Split(";"))
                        {
                            string[] thongTin = thanhPhanGioHang.Split("-");
                            int idSachThem = Int32.Parse(thongTin[0]);

                            if (idSachThem == sach.idSach)
                            {
                                kiemTraGioHang = true;
                            }
                        }
                    }
                    else
                    {
                        HttpContext.Session.SetString("gioHang", "");
                    }
                    
                    if (kiemTraGioHang == false)
                    {
                        if(String.IsNullOrEmpty(HttpContext.Session.GetString("gioHang")))
                        {
                            string sessionGioHang = HttpContext.Session.GetString("gioHang");
                            sessionGioHang = sessionGioHang + idSach + "-" + 1;
                            HttpContext.Session.SetString("gioHang", sessionGioHang);
                        }
                        else
                        {
                            string sessionGioHang = HttpContext.Session.GetString("gioHang");
                            sessionGioHang = sessionGioHang + ";" + idSach + "-" + 1;
                            HttpContext.Session.SetString("gioHang", sessionGioHang);
                        }
                    }   
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }

        public IActionResult xoaSachKhoiGioHang(int idSach)
        {
            string gioHang = "";
            string sessionGioHang = HttpContext.Session.GetString("gioHang");
            foreach (string thanhPhanGioHang in sessionGioHang.Split(";"))
            {
                string[] thongTin = thanhPhanGioHang.Split("-");
                int idSachXoa = Int32.Parse(thongTin[0]);
                int soLuong = Int32.Parse(thongTin[1]);

                if (idSachXoa != idSach)
                {
                    if (gioHang == "")
                    {
                        gioHang = gioHang + idSachXoa + "-" + soLuong;
                    }
                    else
                    {
                        gioHang = gioHang + ";" + idSachXoa + "-" + soLuong;
                    }
                }
            }
            HttpContext.Session.SetString("gioHang", gioHang);
            return RedirectToAction(nameof(xemGioHang));
        }

        public IActionResult xemGioHang()
        {
            List<ThanhPhanGioHang> gioHang = new List<ThanhPhanGioHang>();
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("gioHang")))
            {
                string sessionGioHang = HttpContext.Session.GetString("gioHang");
                foreach (string thanhPhanGioHangString in sessionGioHang.Split(";"))
                {
                    string[] thongTin = thanhPhanGioHangString.Split("-");
                    int idSach = Int32.Parse(thongTin[0]);
                    int soLuong = Int32.Parse(thongTin[1]);

                    var sach = _context.TapHopSach.Where(s => s.idSach == idSach)
                                 .Include(s => s.nhaXuatBan)
                                 .Include(s => s.loaiSach)
                                 .FirstOrDefault();

                    ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();
                    thanhPhanGioHang.sach = sach;
                    thanhPhanGioHang.soLuong = soLuong;
                    gioHang.Add(thanhPhanGioHang);
                }
            }
            return View("GioHang",gioHang);
        }

        private bool thongTinSach(ThanhPhanGioHang thanhPhanGioHang,string thanhPhanGioHangString, int idSach)
        {
            string[] thongTin = thanhPhanGioHangString.Split("-");
            int idSachSua = Int32.Parse(thongTin[0]);
            int soLuong = Int32.Parse(thongTin[1]);

            if (idSachSua == idSach)
            {
                var sach = _context.TapHopSach.Where(s => s.idSach == idSach)
                                .Include(n => n.nhaXuatBan)
                                .Include(l => l.loaiSach)
                                .FirstOrDefault();

                thanhPhanGioHang.sach = sach;
                thanhPhanGioHang.soLuong = soLuong;
                return true;
            }
            return false;
        }

        [HttpGet]
        public IActionResult suaGioHang(int idSach)
        {
            try
            {
                string[] sessionGioHang = HttpContext.Session.GetString("gioHang").Split(";");
                foreach (string thanhPhanGioHangString in sessionGioHang)
                {
                    ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();
                    bool ketQua = thongTinSach(thanhPhanGioHang, thanhPhanGioHangString, idSach);
                    if (ketQua == true)
                    {
                        return View("./SuaGioHang", thanhPhanGioHang);
                    }
                }
            }
            catch (NullReferenceException)
            {
                string thanhPhanGioHangString = HttpContext.Session.GetString("gioHang");
                ThanhPhanGioHang thanhPhanGioHang = new ThanhPhanGioHang();
                bool ketQua = thongTinSach(thanhPhanGioHang, thanhPhanGioHangString, idSach);
                if (ketQua == true)
                {
                    return View("./SuaGioHang", thanhPhanGioHang);
                }
            }
            return RedirectToAction(nameof(xemGioHang));
        }

        private string thayDoiSoLuongSach(string gioHang, string thanhPhanGioHang, int idSach, int soLuong)
        {
            string[] thongTin = thanhPhanGioHang.Split("-");
            int idSachCu = Int32.Parse(thongTin[0]);
            int soLuongCu = Int32.Parse(thongTin[1]);

            if(idSachCu != idSach)
            {
                soLuong = soLuongCu;
            }
            if (String.IsNullOrEmpty(gioHang))
            {
                gioHang = idSachCu + "-" + soLuong;
            }
            else
            {
                gioHang = gioHang + ";" + idSachCu + "-" + soLuong;
            }
            return gioHang;
        }

        public IActionResult suaGioHang(int idSach, int soLuong)
        {
            string gioHang = "";
            try
            {
                string sessionGioHang = HttpContext.Session.GetString("gioHang");
                foreach (string thanhPhanGioHang in sessionGioHang.Split(";"))
                {
                    gioHang = thayDoiSoLuongSach(gioHang, thanhPhanGioHang, idSach, soLuong);
                }
            }
            catch (NullReferenceException)
            {
                string thanhPhanGioHang = HttpContext.Session.GetString("gioHang");
                gioHang = thayDoiSoLuongSach(gioHang, thanhPhanGioHang, idSach, soLuong);
            }
            
            HttpContext.Session.SetString("gioHang", gioHang);
            return RedirectToAction(nameof(xemGioHang));
        }
    }
}
