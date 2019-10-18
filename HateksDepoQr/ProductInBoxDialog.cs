using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace HateksDepoQr
{
    public partial class ProductInBoxDialog : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public ProductInBoxDialog()
        {
            InitializeComponent();
        }
        public ProductInBoxDialog(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }

        private void ProductInBoxDialog_Load(object sender, EventArgs e)
        {
            this.productInGeneratedBoxByIdTableAdapter.Fill(this.depoQrDataSet.ProductInGeneratedBoxById, id);
        }
    }
}