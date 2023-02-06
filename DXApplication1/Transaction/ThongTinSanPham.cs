using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Transaction
{
      public class ThongTinSanPham
        {
            private string MaSP;
            private string tenSP;
            private string loai;
            private int SL;
            private double giaSP;



            public ThongTinSanPham(string MaSP,string tenSP,string loai,int SL,double giaSP)
            {
                this.MaSP = MaSP;
                this.tenSP = tenSP;
                this.giaSP = giaSP;
                this.loai = loai;
                this.SL = SL;
            }

        }
}
