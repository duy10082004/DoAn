using QuanLyKhoHang.Global_Variable;
using QuanLyKhoHang.NhapHang;
using QuanLyKhoHang.tk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyKhoHang
{
    public partial class Account_MH : Form
    {
        public Account_MH()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }
        private void AddGoodsType(string newGoodsType)
        {
            newGoodsType = newGoodsType.Trim();

            if (!string.IsNullOrEmpty(newGoodsType))
            {
                if (!GlobalVariable.goodsTypeCbbValue.Contains(newGoodsType))
                {
                    GlobalVariable.goodsTypeCbbValue.Add(newGoodsType);
                    MessageBox.Show($"Đã thêm loại hàng mới: {newGoodsType}");
                }
                else
                {
                    MessageBox.Show("Loại hàng đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Tên loại hàng không được để trống!");
            }
        }

        private void AddSupplier(string newSupplier)
        {
            newSupplier = newSupplier.Trim();

            if (!string.IsNullOrEmpty(newSupplier))
            {
                if (!GlobalVariable.nhGoodsSupplier.Contains(newSupplier))
                {
                    GlobalVariable.nhGoodsSupplier.Add(newSupplier);
                    MessageBox.Show($"Đã thêm nhà cung cấp mới: {newSupplier}");
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
            }
        }

        private void btnAddGoodsType_Click(object sender, EventArgs e)
        {
            string newGoodsType = txtNewGoodsType.Text;
            AddGoodsType(newGoodsType);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string newSupplier = txtNewSupplier.Text;
            AddSupplier(newSupplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
