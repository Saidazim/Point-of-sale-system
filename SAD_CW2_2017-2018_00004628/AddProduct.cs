using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_CW2_2017_2018_00004628
{
    public partial class AddProduct : UserControl
    {

        private Byte[] imageBytes;
        private PosDbEntities pde = new PosDbEntities();

        public AddProduct()
        {
            //Category.List.Add(new Category() { CategoryName = "Clothes", Value = 1 });
            //Category.List.Add(new Category() { CategoryName = "Foods", Value = 2 });
            //Category.List.Add(new Category() { CategoryName = "Drinks", Value = 3 });

            InitializeComponent();
            cboCategory.DataSource = pde.TblCategories.ToList();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "Category";

        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                FileStream fs = new FileStream(
                        openFileDialog.FileName,
                        FileMode.Open,
                        FileAccess.Read
                    );

                imageBytes = new Byte[fs.Length];

                fs.Read(imageBytes, 0, imageBytes.Length);

                fs.Close();

                MemoryStream mst = new MemoryStream(imageBytes);

                pbImage.Image = Image.FromStream(mst);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();

            product.Name = tbxName.Text;
            product.Price = Int32.Parse(tbxPrice.Text);
            product.Category = (int)cboCategory.SelectedValue;
            product.Image = imageBytes;

            pde.TblProducts.Add(product);
            pde.SaveChanges();
            
            tbxName.Text = string.Empty;
            tbxPrice.Text = string.Empty;
            pbImage.Refresh();

            MessageBox.Show("Product added");

            AllProducts ap = new AllProducts();
            ap.refreshDgv();
            //Application.OpenForms["AllProducts"];
            //((AllProducts)Forms["AllProducts"]).refreshDvg();
        }
    }
}
