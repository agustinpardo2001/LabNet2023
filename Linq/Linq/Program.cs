using Linq.Entities;
using Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customersLogic = new CustomersLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            Customers cObj = customersLogic.GetOne();
            Console.WriteLine("**P1**");
            Console.WriteLine(
                $"Contact Name: {cObj.ContactName} | " +
                $"Company Name: {cObj.CompanyName} | " +
                $"Country: {cObj.Country} | " +
                $"Adress: {cObj.Address} | " +
                $"PostalCode: {cObj.PostalCode} | " +
                $"Contact Title: {cObj.ContactTitle} | " +
                $"Fax: {cObj.Fax} | " +
                $"City: {cObj.City} | " +
                $"ID: {cObj.CustomerID}"
            );

            List<Products> nullStockP = productsLogic.WithoutStock();
            Console.WriteLine(" ");
            Console.WriteLine("**P2**");
            nullStockP.ForEach((p) => Console.WriteLine($"Nombre del producto: {p.ProductName}, Stock: {p.UnitsInStock}"));

            List<Products> nullStockAndPrice = productsLogic.FilterWithStockAndPrice(3);
            Console.WriteLine(" ");
            Console.WriteLine("**P3**");
            nullStockAndPrice.ForEach((p) => Console.WriteLine($"Nombew del producto: {p.ProductName}, Stock: {p.UnitsInStock}"));

            List<Customers> customersWA = customersLogic.GetByRegionWA();
            Console.WriteLine(" ");
            Console.WriteLine("**P4**");
            customersWA.ForEach((c) => Console.WriteLine($"Customer: {c.CompanyName}, Stock: {c.Region}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P5**");
            Products productId = productsLogic.FindById(789);
            if (productId != null)
            {
                Console.WriteLine($"Nombre del producto: {productId.ProductName}, ID: {productId.ProductID}");
            }
            else
            {
                Console.WriteLine("Vacio");
            }

            Console.WriteLine(" ");
            Console.WriteLine("**P6**");
            List<string> customersName = customersLogic.GetAllNames();
            customersName.ForEach((c) => Console.WriteLine($"Customer: {c.ToLower()} || {c.ToUpper()}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P7**");
            List<CustomersDTO> cc = customersLogic.JoinWithOrders();
            cc.ForEach((c) => Console.WriteLine($"Region: {c.Region} {c.OrderDate}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P8**");
            List<Customers> threeWA = customersLogic.GetThreeCustomersWA();
            customersWA.ForEach((c) => Console.WriteLine($"Customer: {c.CompanyName}, Region: {c.Region}, ID {c.CustomerID}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P9**");
            List<Products> orderProductsName = productsLogic.OrderByName();
            orderProductsName.ForEach((p) => Console.WriteLine($"Nombre de producto: {p.ProductName}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P10**");
            List<Products> orderProductsStock = productsLogic.OrderByStockDesc();
            orderProductsStock.ForEach((p) => Console.WriteLine($"Nombre de producto: {p.ProductName}, Stock: {p.UnitsInStock}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P11**");
            List<CategoriesDTO> listCategories = productsLogic.GroupByCategories();
            listCategories.ForEach((c) => Console.WriteLine($"{c.CategoryName}"));

            Console.WriteLine(" ");
            Console.WriteLine("**P12**");
            Products firstProduct = productsLogic.FirstProduct();
            Console.WriteLine($"Nombre: {firstProduct.ProductName}, ID: {firstProduct.ProductID}");

            Console.WriteLine(" ");
            Console.WriteLine("**p13**");
            List<Customers> allCustomers = customersLogic.GetAll();
            allCustomers.ForEach((c) => Console.WriteLine($"Nombre: {c.CompanyName}, Cantidad de ordenes: {c.Orders.Count}"));

            Console.ReadLine();

        }
    }
}
