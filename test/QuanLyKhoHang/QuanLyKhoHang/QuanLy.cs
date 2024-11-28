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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }


        private void KhoHang_Load(object sender, EventArgs e)
        {
            dgvQuanLyHangHoa.DataSource = DanhSachHangHoa.Instance.DsHangHoa;
        }

        private void khBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanLyHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void renderDGV(DataGridView dgv, List<HangHoa> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //renderDGV(dgvQuanLyHangHoa, dsHH.DsHangHoa);
        }

    }
}
