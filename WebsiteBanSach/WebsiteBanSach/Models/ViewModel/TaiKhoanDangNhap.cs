using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.ViewModel
{
    public class TaiKhoanDangNhap
    {
        [Display(Name = "Tên đăng nhập")]
        public string taiKhoan { get; set; }

        [Display(Name = "Mật khẩu")]
        public string matKhau { get; set; }
    }
}
