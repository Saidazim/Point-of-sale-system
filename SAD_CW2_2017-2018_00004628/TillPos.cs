using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class TillPos : MetroFramework.Forms.MetroForm
    {
        private PosDbEntities pde = new PosDbEntities();
        int RowIndex = 0;
        public TillPos()
        {
            InitializeComponent();


            foreach (TblCategory tct in pde.TblCategories)
            {
                Button CategoryButton = new Button();
                CategoryButton.Text = tct.CategoryName;
                CategoryButton.Size = new System.Drawing.Size(100, 25);
                CategoryButton.ForeColor = Color.Black;

                CategoryButton.Tag = tct.Category;

                CategoryFlowPanel.Controls.Add(CategoryButton);

                CategoryButton.Click += CategoryButton_Click;
                CategoryButton.PerformClick();
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            ProductfFlowPanel.Controls.Clear();
            Button CategoryButton = (Button)sender;

            int CategoryID = Convert.ToInt32(CategoryButton.Tag);

            foreach (TblProduct tp in pde.TblProducts)
            {
                Button ProductButton = new Button();
                ProductButton.Text = tp.Name;
                ProductButton.Size = new System.Drawing.Size(100, 25);
                ProductButton.ForeColor = Color.White;

                ProductButton.Tag = tp.ProductID;

                CategoryFlowPanel.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;
                CategoryButton.PerformClick();
            }

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;
            
            int ProductID = Convert.ToInt32(ProductButton.Tag);

            TblProduct ProductDetails = new TblProduct();

            if (CheckProductIsAddedAlready(ProductID))
            {
                int Quantity = Convert.ToInt32(dgvSales.Rows[RowIndex].Cells["Quantity"].Value);
                decimal Price = Convert.ToInt32(dgvSales.Rows[RowIndex].Cells["Price"].Value);

                Quantity++;

                decimal Sum = Convert.ToDecimal(Quantity * Price);

                dgvSales.Rows[RowIndex].Cells["Quantity"].Value = Quantity;
                dgvSales.Rows[RowIndex].Cells["Sum"].Value = Sum;

                lblTotal.Text = CalculateTotal(dgvSales).ToString("# ##0 UZS");
            }
            else
            {
                dgvSales.Rows.Add(ProductDetails.Name, 1, ProductDetails.Price, ProductDetails.Price * 1, ProductID);
                lblTotal.Text = CalculateTotal(dgvSales).ToString("# ##0 UZS");
            }

        }

        private bool CheckProductIsAddedAlready(int productID)
        {
            foreach (DataGridViewRow Row in dgvSales.Rows)
            {
                if (Row.Cells["ProductID"].Value.ToString() == ProductID.ToString())
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotal(DataGridView dgvSales)
        {
            decimal Total = 0;

            foreach (DataGridViewRow Row in dgvSales.Rows)
            {
                decimal Sum = Convert.ToDecimal(Row.Cells["Sum"].Value);
                Total = Total + Sum;
            }

            return Total;
        }

        private void TillPos_Load(object sender, EventArgs e)
        {

        }
    }
}
