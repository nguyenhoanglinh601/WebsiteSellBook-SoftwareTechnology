using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebsiteBanSach.Models.Helper
{
    public class KiemTra
    {
        public static bool kiemTraSDT(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{10})$").Success;
        }
    }
}
