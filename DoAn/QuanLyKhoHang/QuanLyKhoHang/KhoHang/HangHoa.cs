using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyKhoHang.KhoHang
{
    internal class HangHoa
    {
        private string hhMaHangHoa;
        private string hhTenHangHoa;
        private string hhLoaiHangHoa;
        private int hhSoLuong;
        private int hhGiaNhap;
        private int hhGiaBan;
        private string hhNhaCungCap;

        public HangHoa()
        {
            this.hhMaHangHoa = string.Empty;
            this.hhGiaNhap = 0;
            hhLoaiHangHoa = string.Empty;
            this.hhGiaBan = 0;
            this.hhTenHangHoa = string.Empty ;
            this.hhSoLuong = 0;
            hhNhaCungCap = string.Empty ;
        }

        public HangHoa (string hhMaHangHoa, string hhTenHangHoa, string hhLoaiHangHoa, int hhSoLuong, int hhGiaNhap, int hhGiaBan, string hhNhaCungCap)
        {
            this.hhMaHangHoa = hhMaHangHoa;
            this.hhTenHangHoa = hhTenHangHoa;
            this.hhLoaiHangHoa = hhLoaiHangHoa;
            this.hhSoLuong = hhSoLuong;
            this.hhGiaNhap = hhGiaNhap;
            this.hhGiaBan = hhGiaBan;
            this.hhNhaCungCap = hhNhaCungCap;
        }

        public string HhMaHangHoa
        {
            get { return this.hhMaHangHoa; }
            set { this.hhMaHangHoa = value; }
        }

        public string HhTenHangHoa
        {
            get { return this.hhTenHangHoa; }
            set { this.hhTenHangHoa = value; }
        }

        public string HhLoaiHangHoa
        {
            get
            {
                return this.hhLoaiHangHoa;
            }
            set
            {
                this.hhMaHangHoa= value;
            }
        }

        public int HhSoLuong
        {
            get { return this.hhSoLuong; }
            set { this.hhSoLuong = value; }
        }

        public int HhGiaNhap
        {
            get { return this.hhGiaNhap; }
            set { this.hhGiaNhap = value;}  
        }

        public int HhGiaBan
        {
            get { return this.hhGiaBan; }
            set { this.hhGiaBan = value; }
        }

        public string HhNhaCungCap
        {
            get
            {
                return this.hhNhaCungCap;
            }
            set { this.hhNhaCungCap = value; }
        }



    }
}
