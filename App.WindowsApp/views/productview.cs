using App.Core.Contracts;
using App.Core.Models;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.WindowsApp.views
{
    public partial class ProductView : UserControl
    {
        private BindingSource _dgvBindingSource = new BindingSource();
        private IProductService _productService;

        // Product list
        private List<Product> _products = new List<Product>();

        // Constructor (single correct one)
        public ProductView(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;

            this.Load += ProductView_Load;
        }

        // Load event
        private void ProductView_Load(object sender, EventArgs e)
        {
            // Category ComboBox
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            // Stock Status ComboBox
            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            // Load products into grid
            LoadProducts();
        }

        // Load + bind data
        private void LoadProducts()
        {
            GenerateFakeProducts();

            _dgvBindingSource.DataSource = _products;

            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = _dgvBindingSource;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //        dgvProducts.AutoGenerateColumns = true;
            //       dgvProducts.DataSource = null;
            //      dgvProducts.DataSource = _products;
            //      dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Fake data generator
        public void GenerateFakeProducts()
        {
            _products.Clear();

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 90000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Jacket",
                Category = ProductCategoryEnum.Clothing,
                Price = 15000.00m,
                Stock = 15,
                Status = ProductStatusEnum.Active
            });

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "USB",
                Category = ProductCategoryEnum.Electronics,
                Price = 1000.00m,
                Stock = 100,
                Status = ProductStatusEnum.Active
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Hoodie",
                Category = ProductCategoryEnum.Clothing,
                Price = 7000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Low
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Chocolates",
                Category = ProductCategoryEnum.Food,
                Price = 1500.00m,
                Stock = 25,
                Status = ProductStatusEnum.Active
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Sticky Notes",
                Category = ProductCategoryEnum.Stationery,
                Price = 250.00m,
                Stock = 20,
                Status = ProductStatusEnum.Low
            });
                
                
                
                

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Juice",
                Category = ProductCategoryEnum.Food,
                Price = 250.00m,
                Stock = 30,
                Status = ProductStatusEnum.Active
            });
        }

        // ID generator
        private string GenerateId()
        {
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

        // ComboBox events (optional)
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Do nothing (UserControl should not open itself)
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null  );
            prodForm.ShowDialog();

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct= _dgvBindingSource.Current as Product;
            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, SelectedProduct);
                prodForm.ShowDialog();
            }
            //     ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, null);
            //  prodForm.ShowDialog();

        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? SelectedProduct = _dgvBindingSource.Current as Product;

            if (SelectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, SelectedProduct);
                prodForm.ShowDialog();
            }
        }


    }
    
}