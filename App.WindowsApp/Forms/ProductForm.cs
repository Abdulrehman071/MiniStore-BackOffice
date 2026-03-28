using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();

            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cmbCat.Items.Clear();
            cmbCat.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCat.SelectedIndex = 0;

            cmbProductStatus.Items.Clear();
            cmbProductStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbProductStatus.SelectedIndex = 0;




            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {

                txtID.Text = p.Id;
                txtName.Text = p.Name;
                cmbCat.SelectedItem = p.Category;
                cmbProductStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
            }

        }

              /// This method captures keyboard presses to move the "pointer" up and down.
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Move DOWN with the Down Arrow or Enter key
            if (keyData == Keys.Down || keyData == Keys.Enter)
            {
                // SelectNextControl(currentControl, forward, tabStopOnly, nested, wrap)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                return true;
            }

            // Move UP with the Up Arrow
            if (keyData == Keys.Up)
            {
                this.SelectNextControl(this.ActiveControl, false, true, true, true);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
