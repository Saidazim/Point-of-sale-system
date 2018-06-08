namespace SAD_CW2_2017_2018_00004628
{
    partial class ManagerForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.allProducts = new SAD_CW2_2017_2018_00004628.AllProducts();
            this.addProduct1 = new SAD_CW2_2017_2018_00004628.AddProduct();
            this.editProdict = new SAD_CW2_2017_2018_00004628.EditProduct();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.Controls.Add(this.SidePanel);
            this.panel.Controls.Add(this.btnDelete);
           
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Controls.Add(this.btnAllProducts);
            this.panel.Location = new System.Drawing.Point(0, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(201, 453);
            this.panel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SidePanel.Location = new System.Drawing.Point(0, 67);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 80);
            this.SidePanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 80);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(0, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(201, 80);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 80);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.FlatAppearance.BorderSize = 0;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllProducts.ForeColor = System.Drawing.Color.White;
            this.btnAllProducts.Location = new System.Drawing.Point(0, 67);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(201, 80);
            this.btnAllProducts.TabIndex = 0;
            this.btnAllProducts.Text = "All products";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // allProducts
            // 
            this.allProducts.BackColor = System.Drawing.Color.White;
            this.allProducts.Location = new System.Drawing.Point(207, 51);
            this.allProducts.Name = "allProducts";
            this.allProducts.Size = new System.Drawing.Size(821, 393);
            this.allProducts.TabIndex = 2;
            // 
            // addProduct1
            // 
            this.addProduct1.BackColor = System.Drawing.Color.White;
            this.addProduct1.Location = new System.Drawing.Point(207, 51);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(821, 393);
            this.addProduct1.TabIndex = 1;
            // 
            // editProduct1
            // 
            this.editProdict.BackColor = System.Drawing.Color.White;
            this.editProdict.Location = new System.Drawing.Point(207, 51);
            this.editProdict.Name = "editProdict";
            this.editProdict.Size = new System.Drawing.Size(821, 393);
            this.editProdict.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 457);
           this.Controls.Add(this.allProducts);
           this.Controls.Add(this.addProduct1);
            this.Controls.Add(this.editProdict);
            this.Controls.Add(this.panel);
            this.Name = "ManagerForm";
            this.Text = " ";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAllProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel SidePanel;
        private AddProduct addProduct1;
        private AllProducts allProducts;
        private EditProduct editProdict;
    }
}