using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class Till : MetroFramework.Forms.MetroForm
    {
        private BindingList<TblProduct> products = new BindingList<TblProduct>();
        private ObjectContext context = new ObjectContext("name=PosDbEntities");
        List<TblProduct> ProductList = new List<TblProduct>();

        private PosDbEntities pde = new PosDbEntities();

        private int totalTransaction;
     
       
        public Till()
        {
            InitializeComponent();
            lstChosenProducts.DataSource = products;
           
            dgvProduct.DataSource = pde.TblProducts.ToList();
            dgvProduct.Columns["TblCategory"].Visible = false;
            dgvProduct.Columns["Image"].Visible = false;
            dgvProduct.Columns["ProductID"].Visible = false;
            dgvProduct.Columns["TblTransactionItems"].Visible = false;

            CreateTabPanel();
            //AddtoPanel();
        }
        

        private void AddtoPanel()
        {
            int i = 1;
            foreach (TabPage tp in tbcProduct.TabPages)
            {
                ObjectQuery<TblProduct> filteredProduct = 
                    new ObjectQuery<TblProduct>("SELECT VALUE P FROM TblProduct AS P WHERE P.Category =  " + i.ToString(), context);
                FlowLayoutPanel fpl = new FlowLayoutPanel();
                fpl.Dock = DockStyle.Fill;

                foreach(TblProduct tProd in filteredProduct)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Text = tProd.Name;
                    tp.Controls.Add(btn);
                }
                tp.Controls.Add(fpl);
                i++;
            }
        }

        private void CreateTabPanel()
        {
            foreach (TblCategory ct in pde.TblCategories)
            {
                tbcProduct.TabPages.Add(ct.Category.ToString(), ct.CategoryName);
            }
        }

        //private void FormatListItem(object sender, ListControlConvertEventArgs e)
        //{
        //    string currentName = ((TblProduct)e.ListItem).Name;
        //    string currentPrice = ((TblProduct)e.ListItem).Price.ToString();
        //    string currentNamePadded = currentName.PadRight(30);

        //    e.Value = currentNamePadded + currentPrice;

        //}

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstChosenProducts.SelectedRows.Count == 0) {
                MessageBox.Show("Please select at least one product to delete");

                return;
            }

            TblProduct selectedProduct = (TblProduct)lstChosenProducts.SelectedRows[0].DataBoundItem;
            ProductList.Remove(selectedProduct);
            refreshDVG();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                

                ProductList.Add((TblProduct)row.DataBoundItem);

            }
            refreshDVG();


        }

        public void refreshDVG() {
            lstChosenProducts.DataSource = null;
            lstChosenProducts.DataSource = ProductList;
            lstChosenProducts.Update();
            lstChosenProducts.Refresh();

            var price = 0;

            ProductList.ForEach(item => {
                price += item.Price;     
            });

            TotalPriceLabel.Text = price.ToString();
        }

        private void Till_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ProductList = new List<TblProduct>();
            MessageBox.Show("Paid");
            refreshDVG();
        }
    }
}
