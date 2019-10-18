namespace HateksDepoQr
{
    partial class GeneratedPalets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewProductInGeneratedPaletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoQrDataSet = new HateksDepoQr.DepoQrDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaletQr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxQr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductTexttileId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewProductInGeneratedPaletTableAdapter = new HateksDepoQr.DepoQrDataSetTableAdapters.ViewProductInGeneratedPaletTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductInGeneratedPaletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 451);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 408);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewProductInGeneratedPaletBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(583, 399);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewProductInGeneratedPaletBindingSource
            // 
            this.viewProductInGeneratedPaletBindingSource.DataMember = "ViewProductInGeneratedPalet";
            this.viewProductInGeneratedPaletBindingSource.DataSource = this.depoQrDataSet;
            // 
            // depoQrDataSet
            // 
            this.depoQrDataSet.DataSetName = "DepoQrDataSet";
            this.depoQrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPaletQr,
            this.colBoxQr,
            this.colBoxId,
            this.colProductTexttileId,
            this.colCustomerName,
            this.colProductName,
            this.colProductCount,
            this.colStateName,
            this.colStateId,
            this.colPlaceName,
            this.colDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 3;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPaletQr, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBoxQr, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colPaletQr
            // 
            this.colPaletQr.Caption = "Palet Qr";
            this.colPaletQr.FieldName = "PaletQr";
            this.colPaletQr.MinWidth = 25;
            this.colPaletQr.Name = "colPaletQr";
            this.colPaletQr.Visible = true;
            this.colPaletQr.VisibleIndex = 0;
            this.colPaletQr.Width = 94;
            // 
            // colBoxQr
            // 
            this.colBoxQr.Caption = "Koli Qr";
            this.colBoxQr.FieldName = "BoxQr";
            this.colBoxQr.MinWidth = 25;
            this.colBoxQr.Name = "colBoxQr";
            this.colBoxQr.Visible = true;
            this.colBoxQr.VisibleIndex = 0;
            this.colBoxQr.Width = 94;
            // 
            // colBoxId
            // 
            this.colBoxId.FieldName = "BoxId";
            this.colBoxId.MinWidth = 25;
            this.colBoxId.Name = "colBoxId";
            this.colBoxId.Width = 94;
            // 
            // colProductTexttileId
            // 
            this.colProductTexttileId.FieldName = "ProductTexttileId";
            this.colProductTexttileId.MinWidth = 25;
            this.colProductTexttileId.Name = "colProductTexttileId";
            this.colProductTexttileId.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Müşteri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 94;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 94;
            // 
            // colProductCount
            // 
            this.colProductCount.Caption = "Miktar";
            this.colProductCount.FieldName = "ProductCount";
            this.colProductCount.MinWidth = 25;
            this.colProductCount.Name = "colProductCount";
            this.colProductCount.Visible = true;
            this.colProductCount.VisibleIndex = 1;
            this.colProductCount.Width = 94;
            // 
            // colStateName
            // 
            this.colStateName.Caption = "Durum";
            this.colStateName.FieldName = "StateName";
            this.colStateName.MinWidth = 25;
            this.colStateName.Name = "colStateName";
            this.colStateName.Visible = true;
            this.colStateName.VisibleIndex = 2;
            this.colStateName.Width = 94;
            // 
            // colStateId
            // 
            this.colStateId.FieldName = "StateId";
            this.colStateId.MinWidth = 25;
            this.colStateId.Name = "colStateId";
            this.colStateId.Width = 94;
            // 
            // colPlaceName
            // 
            this.colPlaceName.Caption = "Konum";
            this.colPlaceName.FieldName = "PlaceName";
            this.colPlaceName.MinWidth = 25;
            this.colPlaceName.Name = "colPlaceName";
            this.colPlaceName.Visible = true;
            this.colPlaceName.VisibleIndex = 3;
            this.colPlaceName.Width = 94;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 4;
            this.colDate.Width = 94;
            // 
            // viewProductInGeneratedPaletTableAdapter
            // 
            this.viewProductInGeneratedPaletTableAdapter.ClearBeforeFill = true;
            // 
            // GeneratedPalets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GeneratedPalets";
            this.Text = "Üretilen Paletler";
            this.Load += new System.EventHandler(this.GeneratedPalets_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductInGeneratedPaletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DepoQrDataSet depoQrDataSet;
        private System.Windows.Forms.BindingSource viewProductInGeneratedPaletBindingSource;
        private DepoQrDataSetTableAdapters.ViewProductInGeneratedPaletTableAdapter viewProductInGeneratedPaletTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaletQr;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxQr;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductTexttileId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCount;
        private DevExpress.XtraGrid.Columns.GridColumn colStateName;
        private DevExpress.XtraGrid.Columns.GridColumn colStateId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}