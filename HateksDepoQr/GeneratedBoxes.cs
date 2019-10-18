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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace HateksDepoQr
{
    public partial class GeneratedBoxes : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public GeneratedBoxes()
        {
            InitializeComponent();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedRowHandle == e.RowHandle && !view.FocusedColumn.Equals(e.Column)) { e.Appearance.BackColor = Color.Orange; }

        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("Id");

            if (cell != null)
            {
                id = Int32.Parse(cell.ToString());
            }
        }

        private void GeneratedBoxes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoQrDataSet.ViewGeneratedBox' table. You can move, or remove it, as needed.
            this.viewGeneratedBoxTableAdapter.Fill(this.depoQrDataSet.ViewGeneratedBox);

        }

        private void btShowProducts_Click(object sender, EventArgs e)
        {
            object cell = gridView1.GetFocusedRowCellValue("Id");

            if (cell != null)
            {
                id = Int32.Parse(cell.ToString());
                ProductInBoxDialog product = new ProductInBoxDialog(id);
                product.ShowDialog();
            }
            else
            {

                XtraMessageBox.Show("Koli Seçimi Yapınız", "Uyarı", MessageBoxButtons.OK);

            }
        }
    }
}