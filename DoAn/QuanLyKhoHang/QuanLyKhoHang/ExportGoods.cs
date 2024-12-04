using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using QuanLyKhoHang.nv;
using QuanLyKhoHang.xh;
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
    public partial class ExportGoods : Form
    {
        public ExportGoods()
        {
            InitializeComponent();
        }

        private void xhBtnAdd_Click(object sender, EventArgs e)
        {
            bool idx = false;
            string employeeCode = xhTxtEmployeeCode.Text;
            string goodsCode = xhTxtGoodsCode.Text;
            string goodsName = xhTxtGoodsName.Text;
            string goodsType = xhTxtGoodsType.Text;
            int goodsQuantity = int.Parse(xhTxtGoodsQuantity.Text);
            string exportInvoiceID = "DXH" + ListOfInvoice.Instance.InvoiceArray.Count;
            DateTime exportTime = xhDtImportTime.Value;
            Export exportGoods = new Export(employeeCode, goodsCode, goodsName, goodsType, goodsQuantity, exportInvoiceID, exportTime);
            exportGoods.getGoodsExportPrice();
            foreach (HangHoa tmp in DanhSachHangHoa.Instance.DsHangHoa)
            {
                if (tmp.HhMaHangHoa == goodsCode && tmp.HhSoLuong >= goodsQuantity && tmp.HhGiaBan !=0)
                {
                    ExportGoodsList.Instance.addExportGoods(exportGoods);
                    GlobalVariable.fakeExportGoodsList.Add(exportGoods);
                    xhDgvExportGoods.DataSource = GlobalVariable.fakeExportGoodsList.ToList();
                    idx = true;
                    break;
                }
                else
                {
                    idx = false;
                }
            }
            if (idx == false) 
            {
                MessageBox.Show("Kiểm tra lại mã hàng hoặc không đủ số lượng hàng trong kho hoặc chưa cập nhập giá bán!!");            
            }

            xhTxtGoodsCode.Clear();
            xhTxtGoodsName.Clear();
            xhTxtGoodsType.Clear();
            xhTxtGoodsQuantity.Clear();
        }

        private void xhDgvExportGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalVariable.fakeNumber = e.RowIndex;
            xhTxtEmployeeCode.Text = ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].EmployeeCode;
            xhTxtGoodsCode.Text = ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsID;
            xhTxtGoodsName.Text = ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsName;
            xhTxtGoodsType.Text = ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsType;
            xhTxtGoodsQuantity.Text = ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsQuantity.ToString();
        }

        private void xhBtnFix_Click(object sender, EventArgs e)
        {
            ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].EmployeeCode = xhTxtEmployeeCode.Text;
            ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsID = xhTxtGoodsCode.Text;
            ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsName = xhTxtGoodsName.Text;
            ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsType = xhTxtGoodsType.Text;
            ExportGoodsList.Instance.ExportGoodsArray[GlobalVariable.fakeNumber].GoodsQuantity = int.Parse(xhTxtGoodsQuantity.Text);
            xhDgvExportGoods.DataSource = ExportGoodsList.Instance.ExportGoodsArray.ToList();
        }

        private void xhBtnDel_Click(object sender, EventArgs e)
        {
            ExportGoodsList.Instance.ExportGoodsArray.RemoveAt(GlobalVariable.fakeNumber);
            GlobalVariable.fakeExportGoodsList.RemoveAt(GlobalVariable.fakeNumber );
            xhDgvExportGoods.DataSource = GlobalVariable.fakeExportGoodsList.ToList();
        }

        private void ExportGoods_Load(object sender, EventArgs e)
        {

        }

        private void ExportGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariable.clearData();
        }

        private void xhBtnConfirm_Click(object sender, EventArgs e)
        {
            string exportInvoiceID = "DXH" + ListOfInvoice.Instance.InvoiceArray.Count;
            DateTime exportInvoiceTime = xhDtImportTime.Value;
            string employeeCode = xhTxtEmployeeCode.Text;

            InvoiceManager exportInvoice = new InvoiceManager();
            exportInvoice = new ExportInvoice(exportInvoiceID, exportInvoiceTime, employeeCode);
            ListOfInvoice.Instance.addInvoice(exportInvoice);

            foreach (Export tmp in GlobalVariable.fakeExportGoodsList)
            {
                foreach (HangHoa hangHoa in DanhSachHangHoa.Instance.DsHangHoa)
                {
                    if (tmp.GoodsID == hangHoa.HhMaHangHoa)
                    {
                        hangHoa.HhSoLuong -= tmp.GoodsQuantity;
                    }
                }
            }
            GlobalVariable.clearData();
            xhDgvExportGoods.DataSource = GlobalVariable.fakeExportGoodsList;
        }

        private void nhBtnBackward_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
