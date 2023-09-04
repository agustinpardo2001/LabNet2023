using Linq.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class ProductsLogic
    {
        private readonly NorthWindContext context;

        public ProductsLogic()
        {
            context = new NorthWindContext();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Products> WithoutStock()
        {
            return (from p in context.Products
                    where p.UnitsInStock == 0
                    select p).ToList();
        }

        public List<Products> FilterWithStockAndPrice(int price)
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > price).ToList();
        }

        public Products FindById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Products> OrderByName()
        {
            return context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Products> OrderByStockDesc()
        {
            return context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }

        public List<CategoriesDTO> GroupByCategories()
        {
            return (context.Categories.GroupJoin(
                    context.Products,
                    category => category.CategoryID,
                    product => product.CategoryID,
                    (category, products) => 
                        new CategoriesDTO
                        {
                            CategoryName = category.CategoryName.ToString()
                        })
                ).ToList();
        }

        public Products FirstProduct()
        {
            return context.Products.First();
        }
    }
}
