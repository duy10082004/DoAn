using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.NhapHang
{
    internal class DanhSachHangNhap
    {
        private static DanhSachHangNhap _instance;
        private List<HangNhap> hangNhapArr;

        public List<HangNhap> HangNhapArr
        {
            get { return this.hangNhapArr; }
            set { this.hangNhapArr = value; }
        }

        public static DanhSachHangNhap Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DanhSachHangNhap();
                }
                return _instance;
            }
            set { _instance = value; }
        }



        public DanhSachHangNhap()
        {
            hangNhapArr = new List<HangNhap>();
        }

        public DanhSachHangNhap (List<HangNhap> hangNhapArr)
        {
            this.hangNhapArr = hangNhapArr;
        }

        

        public void AddNewGoods(HangNhap tmp)
        {
            hangNhapArr.Add(tmp);
        }


    }
}
