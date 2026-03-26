namespace App.WindowsApp.views
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip2 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            dgvProducts = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            toolStrip2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(372, 42);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(362, 33);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(741, 42);
            cmbStockStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(376, 33);
            cmbStockStatus.TabIndex = 4;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(toolStrip2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9.4F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 20, 18, 20);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1163, 638);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator1, toolStripButton5 });
            toolStrip2.Location = new Point(18, 20);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1127, 37);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 10F);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(77, 32);
            toolStripButton1.Text = "Add";
            toolStripButton1.Click += tsbAdd_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackColor = SystemColors.Control;
            toolStripButton2.Font = new Font("Segoe UI", 10F);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(74, 32);
            toolStripButton2.Text = "Edit";
            toolStripButton2.Click += tsbEdit_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Segoe UI", 10F);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(81, 32);
            toolStripButton3.Text = "View";
            toolStripButton3.Click += tsbView_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Font = new Font("Segoe UI", 10F);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(96, 32);
            toolStripButton4.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Font = new Font("Segoe UI", 10F);
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(103, 32);
            toolStripButton5.Text = "Refresh";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbStockStatus, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(21, 78);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.70492F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.29508F));
            tableLayoutPanel2.Size = new Size(1121, 102);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 12);
            label2.Margin = new Padding(17, 12, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Margin = new Padding(17, 12, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(755, 12);
            label3.Margin = new Padding(17, 12, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Stock Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 42);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 33);
            textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProducts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(21, 188);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 426);
            panel1.TabIndex = 4;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.ScrollBar;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColCategory, ColPrice, ColStock, ColStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.GridColor = SystemColors.Menu;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1121, 426);
            dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColId.DataPropertyName = "ID";
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 8;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 8;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            ColName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ColCategory
            // 
            ColCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategory.DataPropertyName = "Category";
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 8;
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 8;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 8;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 8;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductView";
            Size = new Size(1163, 638);
            Load += ProductView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
