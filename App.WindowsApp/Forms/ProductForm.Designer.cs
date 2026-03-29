namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            nuStock = new NumericUpDown();
            cmbCat = new ComboBox();
            nuPrice = new NumericUpDown();
            cmbProductStatus = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSave = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 246);
            label6.Name = "label6";
            label6.Size = new Size(107, 50);
            label6.TabIndex = 13;
            label6.Text = "ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 194);
            label5.Name = "label5";
            label5.Size = new Size(107, 52);
            label5.TabIndex = 12;
            label5.Text = "Status";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 141);
            label4.Name = "label4";
            label4.Size = new Size(107, 53);
            label4.TabIndex = 11;
            label4.Text = "Stock";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(107, 45);
            label3.TabIndex = 10;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(107, 48);
            label2.TabIndex = 9;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 4);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(380, 31);
            txtName.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(116, 250);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(380, 31);
            txtID.TabIndex = 5;
            // 
            // nuStock
            // 
            nuStock.Location = new Point(116, 145);
            nuStock.Margin = new Padding(3, 4, 3, 4);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(380, 31);
            nuStock.TabIndex = 3;
            // 
            // cmbCat
            // 
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(116, 52);
            cmbCat.Margin = new Padding(3, 4, 3, 4);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(380, 33);
            cmbCat.TabIndex = 1;
            // 
            // nuPrice
            // 
            nuPrice.Location = new Point(116, 100);
            nuPrice.Margin = new Padding(3, 4, 3, 4);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(380, 31);
            nuPrice.TabIndex = 2;
            // 
            // cmbProductStatus
            // 
            cmbProductStatus.FormattingEnabled = true;
            cmbProductStatus.Location = new Point(116, 198);
            cmbProductStatus.Margin = new Padding(3, 4, 3, 4);
            cmbProductStatus.Name = "cmbProductStatus";
            cmbProductStatus.Size = new Size(380, 33);
            cmbProductStatus.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 48);
            label1.TabIndex = 8;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 296);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3237419F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.67626F));
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(nuStock, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbCat, 1, 1);
            tableLayoutPanel1.Controls.Add(nuPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(cmbProductStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtID, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(556, 296);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 296);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 93);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(270, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 66);
            panel3.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(34, 19);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Location = new Point(169, 19);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 7;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 389);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Click += btnSave_Click;
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);



        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtID;
        private NumericUpDown nuStock;
        private ComboBox cmbCat;
        private NumericUpDown nuPrice;
        private ComboBox cmbProductStatus;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnSave;
        private Button button1;
        private Panel panel3;
    }
}