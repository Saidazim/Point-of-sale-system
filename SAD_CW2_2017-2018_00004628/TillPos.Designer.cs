namespace SAD_CW2_2017_2018_00004628
{
    partial class TillPos
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
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductfFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProceed = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(138, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(178, 44);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(32, 430);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 44);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "TOTAL: ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseStyleColors = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSales.ColumnHeadersHeight = 25;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Products,
            this.Quantity,
            this.Price,
            this.Sum,
            this.ProductID});
            this.dgvSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSales.Location = new System.Drawing.Point(32, 125);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(284, 291);
            this.dgvSales.TabIndex = 18;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // CategoryFlowPanel
            // 
            this.CategoryFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CategoryFlowPanel.Location = new System.Drawing.Point(348, 85);
            this.CategoryFlowPanel.Name = "CategoryFlowPanel";
            this.CategoryFlowPanel.Size = new System.Drawing.Size(600, 34);
            this.CategoryFlowPanel.TabIndex = 17;
            // 
            // ProductfFlowPanel
            // 
            this.ProductfFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductfFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductfFlowPanel.Location = new System.Drawing.Point(348, 125);
            this.ProductfFlowPanel.Name = "ProductfFlowPanel";
            this.ProductfFlowPanel.Size = new System.Drawing.Size(600, 349);
            this.ProductfFlowPanel.TabIndex = 14;
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProceed.BackColor = System.Drawing.Color.Lime;
            this.btnProceed.Location = new System.Drawing.Point(196, 480);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(120, 40);
            this.btnProceed.TabIndex = 15;
            this.btnProceed.Text = "Check out";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProceed.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProceed.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(32, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(48, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(215, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "SALE ITEMS";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TillPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 551);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.CategoryFlowPanel);
            this.Controls.Add(this.ProductfFlowPanel);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.metroLabel3);
            this.Name = "TillPos";
            this.Text = "TillPos";
            this.Load += new System.EventHandler(this.TillPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.FlowLayoutPanel CategoryFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductfFlowPanel;
        private MetroFramework.Controls.MetroTile btnProceed;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}