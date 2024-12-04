using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.xh
{
    internal class ExportGoodsList
    {
        private List<Export> exportGoodsArray;
        private static ExportGoodsList _instance;

        public static ExportGoodsList Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExportGoodsList();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public ExportGoodsList()
        {
            this.exportGoodsArray = new List<Export>();
        }

        public ExportGoodsList(List<Export> exportGoodsArray)
        {
               this.exportGoodsArray = exportGoodsArray;
        }

        public List<Export> ExportGoodsArray
        {
            get { return exportGoodsArray; }
            set { this.exportGoodsArray = value; }
        }

        public void addExportGoods (Export tmp)
        {
            exportGoodsArray.Add(tmp);
        } 


    }
}
