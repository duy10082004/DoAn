using QuanLyKhoHang.Global_Variable;
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
            khCbbSort.DataSource = GlobalVariable.khComboboxValue;
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

        private void khBtnUpdateExportPrice_Click(object sender, EventArgs e)
        {
            ExportPirceUpdate tmp = new ExportPirceUpdate();
            tmp.FormClosed += Tmp_FormClosed;
            tmp.ShowDialog();
        }

        private void Tmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvQuanLyHangHoa.DataSource = DanhSachHangHoa.Instance.DsHangHoa.ToList();
        }

        private void dgvQuanLyHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalVariable.fakeString = dgvQuanLyHangHoa.SelectedCells[0].Value.ToString();
        }

        private void khBtnSort_Click(object sender, EventArgs e)
        {
            object tmp = khCbbSort.SelectedItem;
            string cbbSelected = tmp.ToString();

            if (cbbSelected == "Refresh")
            {
                dgvQuanLyHangHoa.DataSource = DanhSachHangHoa.Instance.DsHangHoa.ToList();
                GlobalVariable.clearData();
            }
            else if (cbbSelected == "A->Z")
            {
                GlobalVariable.hhAZsortList = DanhSachHangHoa.Instance.DsHangHoa.OrderBy(hangHoa => hangHoa.HhTenHangHoa).ToList();
                dgvQuanLyHangHoa.DataSource = GlobalVariable.hhAZsortList.ToList(); 
            }
            else if (cbbSelected == "Số Lượng Tồn Kho")
            {
                GlobalVariable.hhQuanTitySort = DanhSachHangHoa.Instance.DsHangHoa.OrderBy(hangHoa => hangHoa.HhSoLuong).ToList();
                dgvQuanLyHangHoa.DataSource = GlobalVariable.hhQuanTitySort;
            }
            else
            {
                foreach (HangHoa hh in DanhSachHangHoa.Instance.DsHangHoa)
                {
                    if (hh.HhGiaBan == 0)
                    {
                        GlobalVariable.hhNonExportPriceSort.Add(hh);
                    }
                }
                dgvQuanLyHangHoa.DataSource = GlobalVariable.hhNonExportPriceSort;
            }



        }
    }
}
