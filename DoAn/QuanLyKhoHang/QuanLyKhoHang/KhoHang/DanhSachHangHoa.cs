using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.KhoHang
{
   
    internal class DanhSachHangHoa
    {
        private List <HangHoa> dsHangHoa;
        public List<HangHoa> DsHangHoa
        {
            get { return this.dsHangHoa; }
            set { this.dsHangHoa = value; }
        }


        private static DanhSachHangHoa _instance;

        public static DanhSachHangHoa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DanhSachHangHoa();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }



        public DanhSachHangHoa()
        {
            this.dsHangHoa = new List<HangHoa>();
        }

        public DanhSachHangHoa(List<HangHoa> dsHangHoa)
        {
            this.dsHangHoa = dsHangHoa;
        }

       

        public bool checkMaHangHoa (HangHoa fakeObject)
        {
            foreach (HangHoa tmp in dsHangHoa)
            {
                if (tmp.HhMaHangHoa == fakeObject.HhMaHangHoa && tmp.HhGiaNhap == fakeObject.HhGiaNhap)
                {
                    tmp.HhSoLuong += fakeObject.HhSoLuong;
                    return false;
                }
            }
            return true;

        }

        public bool themHangHoa (HangHoa fakeObject)
        {
            if (checkMaHangHoa(fakeObject))
            {
                dsHangHoa.Add(fakeObject);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
