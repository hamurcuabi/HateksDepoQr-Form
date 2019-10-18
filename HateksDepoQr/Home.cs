using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace HateksDepoQr
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void CreateMdiForm(DevExpress.XtraEditors.XtraForm form)
        {
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Products)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Products());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CreateMdiForm(new Products());
        }

        private void btnBox_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is ProductInBoxes)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new ProductInBoxes());
        }

        private void btnGeneratedBox_ItemClick(object sender, ItemClickEventArgs e)
        {

            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is GeneratedBoxes)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new GeneratedBoxes());

        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Customers)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Customers());
        }

        private void btnPlace_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is Places  )
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new Places());

        }

        private void btnState_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is States)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new States());
        }

        private void btnPalets_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isexist = false;

            foreach (var form in this.xtraTabbedMdiManager1.MdiParent.MdiChildren)
            {
                if (form is GeneratedPalets)
                {
                    form.BringToFront();
                    isexist = true;
                    break;

                }
            }
            if (!isexist)
                CreateMdiForm(new GeneratedPalets());
        }
    }
}