namespace HateksDepoQr
{
    partial class GeneratedBoxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratedBoxes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewGeneratedBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoQrDataSet = new HateksDepoQr.DepoQrDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxQr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneratedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewGeneratedBoxTableAdapter = new HateksDepoQr.DepoQrDataSetTableAdapters.ViewGeneratedBoxTableAdapter();
            this.btShowProducts = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGeneratedBoxBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 521);
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
            this.tableLayoutPanel2.Controls.Add(this.btShowProducts, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 471);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewGeneratedBoxBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(636, 462);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewGeneratedBoxBindingSource
            // 
            this.viewGeneratedBoxBindingSource.DataMember = "ViewGeneratedBox";
            this.viewGeneratedBoxBindingSource.DataSource = this.depoQrDataSet;
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
            this.colBoxQr,
            this.colMemberName,
            this.colPlaceName,
            this.colPlaceCode,
            this.colStateName,
            this.colStateCode,
            this.colStateDescription,
            this.colCustomerName,
            this.colGeneratedDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStateName, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colMemberName
            // 
            this.colMemberName.Caption = "Kullanıcı";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.MinWidth = 25;
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 1;
            this.colMemberName.Width = 94;
            // 
            // colPlaceName
            // 
            this.colPlaceName.Caption = "Konum";
            this.colPlaceName.FieldName = "PlaceName";
            this.colPlaceName.MinWidth = 25;
            this.colPlaceName.Name = "colPlaceName";
            this.colPlaceName.Visible = true;
            this.colPlaceName.VisibleIndex = 2;
            this.colPlaceName.Width = 94;
            // 
            // colPlaceCode
            // 
            this.colPlaceCode.FieldName = "PlaceCode";
            this.colPlaceCode.MinWidth = 25;
            this.colPlaceCode.Name = "colPlaceCode";
            this.colPlaceCode.Width = 94;
            // 
            // colStateName
            // 
            this.colStateName.Caption = "Durum";
            this.colStateName.FieldName = "StateName";
            this.colStateName.MinWidth = 25;
            this.colStateName.Name = "colStateName";
            this.colStateName.Visible = true;
            this.colStateName.VisibleIndex = 3;
            this.colStateName.Width = 94;
            // 
            // colStateCode
            // 
            this.colStateCode.Caption = "Durum";
            this.colStateCode.FieldName = "StateCode";
            this.colStateCode.MinWidth = 25;
            this.colStateCode.Name = "colStateCode";
            this.colStateCode.Width = 94;
            // 
            // colStateDescription
            // 
            this.colStateDescription.Caption = "Açıklama";
            this.colStateDescription.FieldName = "StateDescription";
            this.colStateDescription.MinWidth = 25;
            this.colStateDescription.Name = "colStateDescription";
            this.colStateDescription.Visible = true;
            this.colStateDescription.VisibleIndex = 3;
            this.colStateDescription.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Müşteri Adı";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            this.colCustomerName.Width = 94;
            // 
            // colGeneratedDate
            // 
            this.colGeneratedDate.Caption = "Tarih";
            this.colGeneratedDate.FieldName = "GeneratedDate";
            this.colGeneratedDate.MinWidth = 25;
            this.colGeneratedDate.Name = "colGeneratedDate";
            this.colGeneratedDate.Visible = true;
            this.colGeneratedDate.VisibleIndex = 4;
            this.colGeneratedDate.Width = 94;
            // 
            // viewGeneratedBoxTableAdapter
            // 
            this.viewGeneratedBoxTableAdapter.ClearBeforeFill = true;
            // 
            // btShowProducts
            // 
            this.btShowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btShowProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btShowProducts.Location = new System.Drawing.Point(130, 3);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(121, 41);
            this.btShowProducts.TabIndex = 0;
            this.btShowProducts.Text = "İçerik Gör";
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // GeneratedBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GeneratedBoxes";
            this.Text = "Üretilmiş Koliler";
            this.Load += new System.EventHandler(this.GeneratedBoxes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGeneratedBoxBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource viewGeneratedBoxBindingSource;
        private DepoQrDataSetTableAdapters.ViewGeneratedBoxTableAdapter viewGeneratedBoxTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxQr;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStateName;
        private DevExpress.XtraGrid.Columns.GridColumn colStateCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStateDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneratedDate;
        private DevExpress.XtraEditors.SimpleButton btShowProducts;
    }
}