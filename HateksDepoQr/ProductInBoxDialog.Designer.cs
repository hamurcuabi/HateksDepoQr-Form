namespace HateksDepoQr
{
    partial class ProductInBoxDialog
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productInGeneratedBoxByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoQrDataSet = new HateksDepoQr.DepoQrDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productInGeneratedBoxByIdTableAdapter = new HateksDepoQr.DepoQrDataSetTableAdapters.ProductInGeneratedBoxByIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInGeneratedBoxByIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productInGeneratedBoxByIdBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(401, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productInGeneratedBoxByIdBindingSource
            // 
            this.productInGeneratedBoxByIdBindingSource.DataMember = "ProductInGeneratedBoxById";
            this.productInGeneratedBoxByIdBindingSource.DataSource = this.depoQrDataSet;
            // 
            // depoQrDataSet
            // 
            this.depoQrDataSet.DataSetName = "DepoQrDataSet";
            this.depoQrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colProductCount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 94;
            // 
            // colProductCount
            // 
            this.colProductCount.Caption = "Ürün Miktarı";
            this.colProductCount.FieldName = "ProductCount";
            this.colProductCount.MinWidth = 25;
            this.colProductCount.Name = "colProductCount";
            this.colProductCount.Visible = true;
            this.colProductCount.VisibleIndex = 0;
            this.colProductCount.Width = 94;
            // 
            // productInGeneratedBoxByIdTableAdapter
            // 
            this.productInGeneratedBoxByIdTableAdapter.ClearBeforeFill = true;
            // 
            // ProductInBoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 390);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductInBoxDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koli içindeki Ürünler";
            this.Load += new System.EventHandler(this.ProductInBoxDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInGeneratedBoxByIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productInGeneratedBoxByIdBindingSource;
        private DepoQrDataSet depoQrDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCount;
        private DepoQrDataSetTableAdapters.ProductInGeneratedBoxByIdTableAdapter productInGeneratedBoxByIdTableAdapter;
    }
}