using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace App.WindowsApp.views
{
    public partial class ProductView : UserControl
    {
        private BindingSource _dgvBindingSource = new BindingSource();
        private IProductService _service;

        // Constructor
        public ProductView(IProductService service)
        {
            InitializeComponent();
            _service = service;
        }

        // Load event
        private void ProductView_Load(object sender, EventArgs e)
        {
            SetupFilters();
            LoadProducts();
        }

        private void SetupFilters()
        {
            // Set up Category ComboBox
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;

            // Set up Stock Status ComboBox
            var stockStatus = new List<object> { "--ALL--" };
            stockStatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStockStatus.DataSource = stockStatus;
            cmbStockStatus.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            // Initial load of all products
            _dgvBindingSource.DataSource = _service.GetAll();
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = _dgvBindingSource;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshGrid()
        {
            string searchText = txtSearch.Text;

            // Handle Category Selection
            ProductCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedIndex > 0 && cmbCategory.SelectedItem is ProductCategoryEnum cat)
            {
                selectedCategory = cat;
            }

            // Handle Status Selection
            ProductStatusEnum? selectedStatus = null;
            if (cmbStockStatus.SelectedIndex > 0 && cmbStockStatus.SelectedItem is ProductStatusEnum st)
            {
                selectedStatus = st;
            }

            // Call the service with all three filters
            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            // Pass 'null' for a new product in Add mode
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            if (prodForm.ShowDialog() == DialogResult.OK || prodForm.DialogResult == DialogResult.Cancel)
            {
                // Refresh after closing to show the new product
                RefreshGrid();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }
        }

        // Event Handlers for Real-time Filtering
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Placeholder for any specific refresh button logic if needed
            RefreshGrid();
        }
    }
}