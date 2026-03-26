using App.Core.Contracts;
using App.Core.Services;
using App.WindowsApp.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private IProductService _productService = new InMemoryProductService();
        private Button _activeNavButton;

        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalfore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;

            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalfore;
                _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
            }

            _activeNavButton = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavActiveFore;
            _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh Called!");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
            SetActiveNavButton(dashboard);
        }

        private void btnprducts_Click(object sender, EventArgs e)
        {
            ShowView(() => new ProductView(_productService));
            SetActiveNavButton(btnprducts);
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            panel2.Controls.Clear();

            var view = factory();
            view.Dock = DockStyle.Fill;

            panel2.Controls.Add(view);
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // Load Dashboard by default
        //  ShowView(() => new DashboardView());

    }
}