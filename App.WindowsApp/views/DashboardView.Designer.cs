using System.Windows.Forms;

namespace App.WindowsApp.views
{
    partial class DashboardView
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
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Tabs", "5" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Chargers", "10" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Airpods", "25" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Watches", "27" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "ID-101", "Zain", "8900", "Pending" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "ID-107", "Usman", "5700", "Paid" }, -1);
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "ID-109", "Hassan", "6000", "Paid" }, -1);
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "ID-170", "Ayyan", "17,000", "Paid" }, -1);
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "ID-3203", "Musa", "149,000", "Paid" }, -1);
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "ID-3471", "Tahsin", "4000", "Pending" }, -1);
            tblDashboard = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label7 = new Label();
            panel5 = new Panel();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label8 = new Label();
            tblDashboard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.AutoSize = true;
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(tableLayoutPanel1, 0, 0);
            tblDashboard.Controls.Add(panel4, 0, 1);
            tblDashboard.Controls.Add(panel5, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Font = new Font("Segoe UI", 9F);
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(18, 20, 18, 20);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(1050, 828);
            tblDashboard.TabIndex = 0;
            tblDashboard.Paint += tblDashboard_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(21, 24);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.Size = new Size(1008, 142);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 134);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 51);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "110";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(335, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 134);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 49);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 1;
            label4.Text = "57";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(50, 45);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 0;
            label3.Text = "Orders";
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(667, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 134);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 48);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 1;
            label6.Text = "357$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.WaitCursor;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(36, 45);
            label5.Name = "label5";
            label5.Size = new Size(99, 30);
            label5.TabIndex = 0;
            label5.Text = "Revenue";
            // 
            // panel4
            // 
            panel4.Controls.Add(listView1);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(21, 174);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1008, 311);
            panel4.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14 });
            listView1.Location = new Point(13, 45);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(975, 262);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Stock";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product";
            columnHeader1.Width = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 16);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 0;
            label7.Text = "Low Stock";
            // 
            // panel5
            // 
            panel5.Controls.Add(listView2);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(21, 493);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1008, 311);
            panel5.TabIndex = 2;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20 });
            listView2.Location = new Point(13, 49);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(975, 244);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Order";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Customer";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Total";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 100;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 20);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 0;
            label8.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(1050, 828);
            tblDashboard.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
    }
}
