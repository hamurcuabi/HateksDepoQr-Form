﻿using System;
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
    public partial class ProductInBoxes : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        public ProductInBoxes()
        {
            InitializeComponent();
        }

        private void ProductInBoxes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoQrDataSet.ViewProductInBox' table. You can move, or remove it, as needed.
            this.viewProductInBoxTableAdapter.Fill(this.depoQrDataSet.ViewProductInBox);
           

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
    }
}