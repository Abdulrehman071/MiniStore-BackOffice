using App.WinForms.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WinForms
{
    public partial class MainForm : Form
    {
        private Button _activeNavButton;

        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);

        private readonly Color NavNormalfore = Color.Black;
        private readonly Color NavActiveFore = Color.Black;

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
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
        // private void Refresh(object sender, EventArgd e)
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh Called!");
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //panel2.Controls.Add(new DashboardView());
            ShowView(() => new DashboardView());
            SetActiveNavButton(dashboard);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprducts_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //panel2.Controls.Add(new ProductView());
            ShowView(() => new ProductView());
            SetActiveNavButton(btnprducts);

        }
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;
            }

            panel2.Controls.Clear();
            panel2.Controls.Add(view);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
