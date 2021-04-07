using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanSach.Models.ViewModel
{
    public class TaiKhoanDangKiKhachHang
    {
        public TaiKhoanKhachHang taiKhoanKhachHang { get; set; }

        public string xacNhanMatKhau { get; set; }
    }
}
