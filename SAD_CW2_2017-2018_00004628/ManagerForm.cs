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
    public partial class ManagerForm : MetroFramework.Forms.MetroForm
    {
        public static ManagerForm instance { get; set; }

        public ManagerForm()
        {
            instance = this;
            InitializeComponent();
            SidePanel.Height = btnAllProducts.Height;
            SidePanel.Top = btnAllProducts.Top;
            allProducts.BringToFront();
        }

        public void btnAllProducts_Click(object sender, EventArgs e)
        {
            OpenAllProduct();
        }

        public void OpenAllProduct() {
            SidePanel.Height = btnAllProducts.Height;
            SidePanel.Top = btnAllProducts.Top;
            allProducts.BringToFront();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAdd.Height;
            SidePanel.Top = btnAdd.Top;
            addProduct1.BringToFront();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        public void ShowEditForm(TblProduct product) {
            SidePanel.Height = btnEdit.Height;
            SidePanel.Top = btnEdit.Top;
            editProdict.setModel(product);
            editProdict.BringToFront();

        }




    }
}
