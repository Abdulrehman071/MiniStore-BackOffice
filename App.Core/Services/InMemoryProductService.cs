using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;
        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }


        public Product Add(Product product)
        {
            if (product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);
            }
            return product;
        }
        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? existing = _products.Find(p=>p.Id == product.Id );
                if (existing == null) return false;

                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.Price = product.Price;
                existing.Status = product.Status;
                existing.Stock = product.Stock;

                return true;

            }
                return false;
        }

        public bool Delete(string id)
        {
            Product prodToBeDeleted = GetById(id);
            _products.Remove(prodToBeDeleted);
            return true;

        }

        public Product GetById(string id)
        {
            Product? prod = _products.Find(p => p.Id == id);
            return prod;
        }

        public List<Product> GetAll()
        {
           
            return _products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            //linq
            List<Product> _filtered = _products.ToList();

            _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();

            if (category is not null)
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }
            if (status is not null)
            {
                _filtered = _filtered.Where(p => p.Status == status).ToList();
            }
            return _filtered;
        }


       
        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 90000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });

                                 
            
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "jacket",
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
                Name = "hoodie",
                Category = ProductCategoryEnum.Clothing,
                Price = 7000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Low
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "coat",
                Category = ProductCategoryEnum.Clothing,
                Price = 15000.00m,
                Stock = 15,
                Status = ProductStatusEnum.Active
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "chocolates",
                Category = ProductCategoryEnum.Food,
                Price = 1500.00m,
                Stock = 25,
                Status = ProductStatusEnum.Active
            });


            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "sticky Notes",
                Category = ProductCategoryEnum.Stationery,
                Price = 250.00m,
                Stock = 20,
                Status = ProductStatusEnum.Low
            });





            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "juice",
                Category = ProductCategoryEnum.Food,
                Price = 250.00m,
                Stock = 30,
                Status = ProductStatusEnum.Active
            });
        








        }

        private string GenerateId()
        {
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}

    

