using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class ExportPirceUpdate : Form
    {
        public ExportPirceUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HangHoa tmp in DanhSachHangHoa.Instance.DsHangHoa)
            {
                if (tmp.HhMaHangHoa == GlobalVariable.fakeString)
                {
                    tmp.HhGiaBan = int.Parse(exportGoodsPriceUpdateTxt.Text);
                    break;
                }
            }
            this.Close();
        }

        private void ExportPirceUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.clearData();
        }

        private void ExportPirceUpdate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
