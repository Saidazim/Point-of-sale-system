using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class EditProduct : UserControl
    {
        public TblProduct Product { get; set; }
        public EditProduct()
        {
            InitializeComponent();
        }

        private PosDbEntities pde = new PosDbEntities();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();
            
            product.Name = tbxName.Text;
            product.Category = (int)cboCategory.SelectedValue;
         
            pde.TblProducts.Add(product);
            
            pde.SaveChanges();
            ManagerForm.instance.OpenAllProduct();
        }

        public void setModel(TblProduct product) {
            tbxName.Text = product.Name;

            
        }

    }
}
