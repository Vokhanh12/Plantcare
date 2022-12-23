using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Subject.Login
{
    class LoginDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public string SYSTEM { get; set; }
        public string TAI_KHOANG { get; set; }

        public string TenQL { get; set; }
        public string MaQL { get; set; }
        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public string TenAD { get; set; }
        public string MaAD { get; set; }
        public string NGAY_DANG_NHAP { get; set; }
    }
    
}
