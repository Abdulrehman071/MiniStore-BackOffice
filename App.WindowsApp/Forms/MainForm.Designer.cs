namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Admin = new Button();
            panel3 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            dashboard = new Button();
            btnprducts = new Button();
            btnorders = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Settings = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 577);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(973, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 46);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(169, 46);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 0;
            button1.Text = "Ministore";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Admin);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(858, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(115, 46);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Admin
            // 
            Admin.Font = new Font("Segoe UI", 9F);
            Admin.Image = (Image)resources.GetObject("Admin.Image");
            Admin.ImageAlign = ContentAlignment.TopLeft;
            Admin.Location = new Point(3, 3);
            Admin.Name = "Admin";
            Admin.Size = new Size(115, 43);
            Admin.TabIndex = 0;
            Admin.Text = "Admin";
            Admin.TextImageRelation = TextImageRelation.ImageBeforeText;
            Admin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 531);
            panel3.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(dashboard);
            flowLayoutPanel3.Controls.Add(btnprducts);
            flowLayoutPanel3.Controls.Add(btnorders);
            flowLayoutPanel3.Controls.Add(button4);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(button6);
            flowLayoutPanel3.Controls.Add(Settings);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Font = new Font("Segoe UI", 10F);
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(169, 429);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // dashboard
            // 
            dashboard.Dock = DockStyle.Top;
            dashboard.FlatAppearance.BorderSize = 0;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Image = (Image)resources.GetObject("dashboard.Image");
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.Location = new Point(3, 3);
            dashboard.MinimumSize = new Size(105, 35);
            dashboard.Name = "dashboard";
            dashboard.Padding = new Padding(10, 0, 0, 0);
            dashboard.Size = new Size(200, 55);
            dashboard.TabIndex = 0;
            dashboard.TabStop = false;
            dashboard.Text = "Dashboard";
            dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboard.UseVisualStyleBackColor = true;
            dashboard.Click += btnDashboard_Click;
            // 
            // btnprducts
            // 
            btnprducts.Dock = DockStyle.Top;
            btnprducts.FlatAppearance.BorderSize = 0;
            btnprducts.FlatStyle = FlatStyle.Flat;
            btnprducts.Image = (Image)resources.GetObject("btnprducts.Image");
            btnprducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnprducts.Location = new Point(3, 64);
            btnprducts.MinimumSize = new Size(100, 30);
            btnprducts.Name = "btnprducts";
            btnprducts.Padding = new Padding(10, 0, 0, 0);
            btnprducts.Size = new Size(200, 55);
            btnprducts.TabIndex = 1;
            btnprducts.Text = "products";
            btnprducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnprducts.UseVisualStyleBackColor = true;
            btnprducts.Click += btnprducts_Click;
            // 
            // btnorders
            // 
            btnorders.Dock = DockStyle.Top;
            btnorders.FlatAppearance.BorderSize = 0;
            btnorders.FlatStyle = FlatStyle.Flat;
            btnorders.Image = (Image)resources.GetObject("btnorders.Image");
            btnorders.ImageAlign = ContentAlignment.MiddleLeft;
            btnorders.Location = new Point(3, 125);
            btnorders.MinimumSize = new Size(100, 30);
            btnorders.Name = "btnorders";
            btnorders.Padding = new Padding(10, 0, 0, 0);
            btnorders.Size = new Size(200, 55);
            btnorders.TabIndex = 2;
            btnorders.Text = "Orders";
            btnorders.TextAlign = ContentAlignment.MiddleLeft;
            btnorders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnorders.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 186);
            button4.MinimumSize = new Size(100, 30);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(200, 55);
            button4.TabIndex = 3;
            button4.Text = "Reports";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 247);
            button5.MinimumSize = new Size(100, 30);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(200, 55);
            button5.TabIndex = 4;
            button5.Text = "Sync";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 308);
            button6.MinimumSize = new Size(100, 30);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(200, 55);
            button6.TabIndex = 5;
            button6.Text = "Logs";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            Settings.FlatAppearance.BorderSize = 0;
            Settings.FlatStyle = FlatStyle.Flat;
            Settings.Image = (Image)resources.GetObject("Settings.Image");
            Settings.ImageAlign = ContentAlignment.MiddleLeft;
            Settings.Location = new Point(3, 369);
            Settings.MinimumSize = new Size(100, 30);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(10, 0, 0, 0);
            Settings.Size = new Size(170, 55);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            Settings.TextAlign = ContentAlignment.MiddleRight;
            Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            Settings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(169, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 531);
            panel2.TabIndex = 6;
            panel2.Click += btnDashboard_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 599);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnprducts;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}

