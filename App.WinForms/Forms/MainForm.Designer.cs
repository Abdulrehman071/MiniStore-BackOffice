namespace App.WinForms
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Admin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboard = new System.Windows.Forms.Button();
            this.btnprducts = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 46);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(169, 46);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ministore";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Admin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(797, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(97, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.Image = ((System.Drawing.Image)(resources.GetObject("Admin.Image")));
            this.Admin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Admin.Location = new System.Drawing.Point(3, 3);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(94, 43);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin";
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 450);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.dashboard);
            this.flowLayoutPanel3.Controls.Add(this.btnprducts);
            this.flowLayoutPanel3.Controls.Add(this.btnorders);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Controls.Add(this.button5);
            this.flowLayoutPanel3.Controls.Add(this.button6);
            this.flowLayoutPanel3.Controls.Add(this.Settings);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(166, 450);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // dashboard
            // 
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboard.Location = new System.Drawing.Point(3, 3);
            this.dashboard.MinimumSize = new System.Drawing.Size(105, 30);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(133, 36);
            this.dashboard.TabIndex = 0;
            this.dashboard.TabStop = false;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnprducts
            // 
            this.btnprducts.FlatAppearance.BorderSize = 0;
            this.btnprducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprducts.Image = ((System.Drawing.Image)(resources.GetObject("btnprducts.Image")));
            this.btnprducts.Location = new System.Drawing.Point(3, 45);
            this.btnprducts.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnprducts.Name = "btnprducts";
            this.btnprducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnprducts.Size = new System.Drawing.Size(119, 30);
            this.btnprducts.TabIndex = 1;
            this.btnprducts.Text = "products";
            this.btnprducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprducts.UseVisualStyleBackColor = true;
            this.btnprducts.Click += new System.EventHandler(this.btnprducts_Click);
            // 
            // btnorders
            // 
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Image = ((System.Drawing.Image)(resources.GetObject("btnorders.Image")));
            this.btnorders.Location = new System.Drawing.Point(3, 81);
            this.btnorders.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnorders.Size = new System.Drawing.Size(100, 30);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "Orders";
            this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(3, 117);
            this.button4.MinimumSize = new System.Drawing.Size(100, 30);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reports";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 153);
            this.button5.MinimumSize = new System.Drawing.Size(100, 30);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sync";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 189);
            this.button6.MinimumSize = new System.Drawing.Size(100, 30);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "Logs";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Settings.Location = new System.Drawing.Point(3, 225);
            this.Settings.MinimumSize = new System.Drawing.Size(100, 30);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Settings.Size = new System.Drawing.Size(133, 30);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(169, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 450);
            this.panel2.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

