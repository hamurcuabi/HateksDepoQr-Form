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
    public partial class Places : DevExpress.XtraEditors.XtraForm
    {

        private int id;

        public Places()
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

        private void Places_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoQrDataSet.Place' table. You can move, or remove it, as needed.
            this.placeTableAdapter.Fill(this.depoQrDataSet.Place);

        }
    }
}