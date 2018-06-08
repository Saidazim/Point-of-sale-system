namespace SAD_CW2_2017_2018_00004628
{
    partial class Till
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
            this.btnDeleteItem = new MetroFramework.Controls.MetroButton();
            this.tbxTitle = new MetroFramework.Controls.MetroTextBox();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lstChosenProducts = new System.Windows.Forms.DataGridView();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcProduct = new MetroFramework.Controls.MetroTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstChosenProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(491, 509);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(130, 37);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(60, 71);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(144, 23);
            this.tbxTitle.TabIndex = 3;
            this.tbxTitle.Text = "New";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(662, 508);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 38);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(60, 509);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(122, 37);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(60, 54);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(228, 433);
            this.dgvProduct.TabIndex = 7;
            // 
            // lstChosenProducts
            // 
            this.lstChosenProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstChosenProducts.Location = new System.Drawing.Point(294, 54);
            this.lstChosenProducts.Name = "lstChosenProducts";
            this.lstChosenProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstChosenProducts.Size = new System.Drawing.Size(671, 433);
            this.lstChosenProducts.TabIndex = 8;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.TotalPriceLabel.Location = new System.Drawing.Point(933, 512);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(24, 26);
            this.TotalPriceLabel.TabIndex = 9;
            this.TotalPriceLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(802, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Price:";
            // 
            // tbcProduct
            // 
            this.tbcProduct.Location = new System.Drawing.Point(60, 100);
            this.tbcProduct.Name = "tbcProduct";
            this.tbcProduct.Size = new System.Drawing.Size(272, 22);
            this.tbcProduct.TabIndex = 1;
            // 
            // Till
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.lstChosenProducts);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.tbcProduct);
            this.Name = "Till";
            this.Text = "Till";
            this.Load += new System.EventHandler(this.Till_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstChosenProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnDeleteItem;
        private MetroFramework.Controls.MetroTextBox tbxTitle;
        private MetroFramework.Controls.MetroButton btnPay;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView lstChosenProducts;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabControl tbcProduct;
    }
}