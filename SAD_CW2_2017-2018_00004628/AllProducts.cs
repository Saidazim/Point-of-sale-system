using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class AllProducts : UserControl
    {
        private PosDbEntities pde = new PosDbEntities();
       
        public AllProducts()
        {
            InitializeComponent();
            dgvProduct.DataSource = pde.TblCategories.ToList();
            refreshDgv();
            //dgvProduct.Columns["TblCategory"].Visible = false;
            //dgvProduct.Columns["ProductID"].Visible = false;
            //dgvProduct.Columns["TblTransactionItems"].Visible = false;

            cboFilter.DataSource = pde.TblCategories.ToList(); ;
            cboFilter.DisplayMember = "CategoryName";
            cboFilter.ValueMember = "Category";
        }

        public void refreshDgv(List<TblProduct> list = null)
        {
            if (list == null) {
                list = pde.TblProducts.ToList();
            }
            dgvProduct.DataSource = list;
            dgvProduct.Update();
            dgvProduct.Refresh();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDgv();
        }

        private void FilterList(object sender, EventArgs e)
        {
            var list = pde.TblProducts.Where(item => item.Category == (int)cboFilter.SelectedValue).ToList();
            refreshDgv(list);
            //ObjectQuery<TblProduct> filteredProducts = new ObjectQuery<TblProduct>(
            //    "SELECT VALUE product FROM TblProduct AS product WHERE product.Category = " + cboFilter.SelectedValue, pde);
            //dgvProduct.DataSource = filteredProducts;

            //for (int i = 0; i < dgvProduct.RowCount; i++) // This will apply to all rows
            //{
            //    List<Category> List = new List<Category>();
            //    foreach (object o in List) // the variable "typeID" gets all doctype IDs in the table
            //    {
            //        if (o == cboFilter.SelectedValue)  // should check what the user selected under group
            //            List.Add(o.ToString());
            //    }
            //    foreach (object o in List)
            //    {
            //        cboFilter.Items.Add(o);  // should fill the doc type combobox based on choice of docgroup combobox
            //    }
            //}

            //for (int i = 0; i < dgvProduct.RowCount; i++) // This will apply to all rows
            //{
            //    List<Category> List = new List<Category>();
            //    foreach (Category o in List) // the variable "typeID" gets all doctype IDs in the table
            //    {
            //        if (o == cboFilter.SelectedValue)  // should check what the user selected under group
            //            List.Add(o);
            //    }
            //    foreach (object o in List)
            //    {
            //        cboFilter.Items.Add(o);  // should fill the doc type combobox based on choice of docgroup combobox
            //    }
            //}

            //ObjectQuery<Category.List> filteredProducts = new ObjectQuery<Category.List>(
            //    "Select value product From Category.List as product Where product.Category = " + cboFilter.SelectedValue);
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count != 1) {
                MessageBox.Show("Select one product");
                return;
            }

            ManagerForm.instance.ShowEditForm(dgvProduct.SelectedRows[0].DataBoundItem as TblProduct);
        }
    }
}
