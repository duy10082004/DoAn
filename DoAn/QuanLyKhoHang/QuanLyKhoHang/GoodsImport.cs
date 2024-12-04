using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.hd;
using QuanLyKhoHang.KhoHang;
using QuanLyKhoHang.NhapHang;
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
    public partial class GoodsImport : Form
    {
        public GoodsImport()
        {
            InitializeComponent();
        }

        private int importGoodsOderCode = 1;
        private int goodsListLocate = -1;

        private void clearTextBox()
        {
            //nhTxtEmployeeCode.Clear();
            nhTxtGoodsCode.Clear();
            nhTxtGoodsImportPrice.Clear();
            nhTxtGoodsName.Clear();
            nhTxtGoodsQuantity.Clear();
            nhTxtGoodsType.Clear();
        }



        private void nhBtnAdd_Click(object sender, EventArgs e)
        {
            string nhEmployeeCode = nhTxtEmployeeCode.Text;
            DateTime nhImportTime = nhDtImportTime.Value;
            string nhGoodsCode = nhTxtGoodsCode.Text;
            string nhGoodsName = nhTxtGoodsName.Text;
            string nhGoodsType = nhTxtGoodsType.Text;
            int nhGoodsQuantity = int.Parse(nhTxtGoodsQuantity.Text);
            int nhGoodsImportPrice = int.Parse(nhTxtGoodsImportPrice.Text);
            HangNhap tmp = new HangNhap( nhEmployeeCode, nhImportTime, nhGoodsCode, nhGoodsName, nhGoodsType, nhGoodsQuantity, nhGoodsImportPrice);
            tmp.NhImportOderCode = "DNH" + ListOfInvoice.Instance.InvoiceArray.Count;
            DanhSachHangNhap.Instance.AddNewGoods(tmp);
            GlobalVariable.fakeListImportGoods.Add(tmp);
            nhDgvImportGoodsList.DataSource = GlobalVariable.fakeListImportGoods.ToList();
            clearTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhBtnConfirm_Click(object sender, EventArgs e)
        {
            string invoiceID = "DNH" + ListOfInvoice.Instance.InvoiceArray.Count;
            importGoodsOderCode++;
            InvoiceManager importInvoice = new InvoiceManager();
            importInvoice = new ImportInvoice(invoiceID, nhDtImportTime.Value, nhTxtEmployeeCode.Text);
            ListOfInvoice.Instance.addInvoice(importInvoice);

            
            foreach (HangNhap tmp in DanhSachHangNhap.Instance.HangNhapArr)
            {
                if (tmp.NhImportOderCode == invoiceID)
                {
                    DanhSachHangHoa.Instance.themHangHoa(new HangHoa(tmp.NhGoodsCode, 
                        tmp.NhGoodsName, tmp.NhGoodsType, tmp.NhGoodsQuantity, tmp.NhGoodsImportPrice, 0));
                    MessageBox.Show("Đã Cập Nhật Kho Hàng");
                }
            }

            GlobalVariable.clearData();
            nhDgvImportGoodsList.DataSource = GlobalVariable.fakeListImportGoods.ToList();

        }

        private void nhBtnBackward_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhDgvImportGoodsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            goodsListLocate = e.RowIndex;
            nhTxtEmployeeCode.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhEmployeeCode;
            nhTxtGoodsCode.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsCode;
            nhTxtGoodsName.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsName;
            nhTxtGoodsType.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsType;
            nhTxtGoodsQuantity.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsQuantity.ToString();
            nhTxtGoodsImportPrice.Text = DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsImportPrice.ToString();
        }

        private void nhBtnFix_Click(object sender, EventArgs e)
        {
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhEmployeeCode = nhTxtEmployeeCode.Text;
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsCode = nhTxtGoodsCode.Text;
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsName = nhTxtGoodsName.Text;
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsType = nhTxtGoodsType.Text;
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsQuantity = int.Parse(nhTxtGoodsQuantity.Text);
            DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate].NhGoodsImportPrice = int.Parse(nhTxtGoodsImportPrice.Text);

            GlobalVariable.fakeListImportGoods[goodsListLocate].NhEmployeeCode = nhTxtEmployeeCode.Text;
            GlobalVariable.fakeListImportGoods[goodsListLocate].NhGoodsCode = nhTxtGoodsCode.Text;
            GlobalVariable.fakeListImportGoods[goodsListLocate].NhGoodsName = nhTxtGoodsName.Text;
            GlobalVariable.fakeListImportGoods[goodsListLocate].NhGoodsType = nhTxtGoodsType.Text;
            GlobalVariable.fakeListImportGoods[goodsListLocate].NhGoodsQuantity = int.Parse(nhTxtGoodsQuantity.Text);
            GlobalVariable.fakeListImportGoods[goodsListLocate].NhGoodsImportPrice = int.Parse(nhTxtGoodsImportPrice.Text);
            nhDgvImportGoodsList.DataSource = GlobalVariable.fakeListImportGoods.ToList();
        }

        private void nhBtnDel_Click(object sender, EventArgs e)
        {
            DanhSachHangNhap.Instance.HangNhapArr.Remove(DanhSachHangNhap.Instance.HangNhapArr[goodsListLocate]);
            GlobalVariable.fakeListImportGoods.Remove(GlobalVariable.fakeListImportGoods[goodsListLocate]);
            nhDgvImportGoodsList.DataSource = GlobalVariable.fakeListImportGoods.ToList();
        }


    }
}
   