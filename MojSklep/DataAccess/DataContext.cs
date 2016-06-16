using Microsoft.VisualStudio.TestTools.UnitTesting;
using MojSklep.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojSklep.DataAccess
{
    class DataContext
    {
        /*static List<Produkty> produkty = new List<Produkty>();
        static List<Clients> clients = new List<Clients>();
        static List<Employee> employee = new List<Employee>();*/
        static StoreContext context = new StoreContext();
        public static StoreContext Context
        {
            get { return context; }
        }
        /// <summary>
        /// Zwraca listę  obiektów Klients
        /// </summary>
        /// <returns></returns>
        public static List<Clients> GetClientList() 
        {
            return context.Clients.ToList();
        }
        /// <summary>
        ///  Zwraca listę  obiektów Produkty
        /// </summary>
        /// <returns></returns>
        public static List<Produkty> GetProductList() 
        {
            return context.Products.ToList();
        }
        /// <summary>
        /// Zwraca listę  obiektów Pracowników
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployeeList() 
        {
            return context.Employees.ToList();
        }
        /// <summary>
        /// Metoda za pomącą jakiej tworzy nowego klienta lub edytuje dane
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddOrEditClient(Clients value) 
        {
            if (value.ClientId == 0)
            {
                value.ClientId = context.Clients.Count() > 0 ? context.Clients.Max(x => x.ClientId) + 1 : 1;
                context.Clients.Add(value);
            }
            else
            {
                Clients client = context.Clients.FirstOrDefault(x => x.ClientId == value.ClientId);
                if (client != null)
                {
                    client.ClientName = value.ClientName;
                    client.Address = value.Address;
                    client.Discount = value.Discount;
                    client.Vip = value.Vip;
                }
            }
            context.SaveChanges();

            return true;
        }
        /// <summary>
        /// Metoda za pomocą jakiej tworzy nowy Produkt lub edytyje go
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddOrEditProduct(Produkty value) 
        {
            if (value.ProductId == 0)
            {
                value.ProductId = context.Products.Count() > 0 ? context.Products.Max(x => x.ProductId) + 1 : 1;
                context.Products.Add(value);
            }
            else
            {
                Produkty product = context.Products.FirstOrDefault(x => x.ProductId == value.ProductId);
                if (product != null)
                {

                    product.ProductName = value.ProductName;
                    product.Group = value.Group;
                    product.LotNumber = value.LotNumber;
                    product.StockAmount = value.StockAmount;
                    product.Color = value.Color;
                    product.IsBestseller = value.IsBestseller;
                    product.Description = value.Description;

                }
            }
            context.SaveChanges();

            return true;

        }
        /// <summary>
        /// Metoda za pomocą jakiej tworzy nowy Pracownik lub edytyje go
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddOrEditEmployee(Employee value)
        {
            if (value.EmployeeId == 0)
            {
                value.EmployeeId = context.Employees.Count() > 0 ? context.Employees.Max(x => x.EmployeeId) + 1 : 1;
                context.Employees.Add(value);
            }
            else
            {
                Employee employe = context.Employees.FirstOrDefault(x => x.EmployeeId == value.EmployeeId);
                if (employe != null)
                {

                    employe.PracownikName = value.PracownikName;
                    employe.PositionPrac = value.PositionPrac;
                    employe.AddressZam = value.AddressZam;
                    employe.ClockJob = value.ClockJob;
                    employe.InfoPrac = value.InfoPrac;
                    employe.TelNumberPracownik = value.TelNumberPracownik;
                    employe.Wiek = value.Wiek;

                }
            }
            context.SaveChanges();

            return true;
        }
        
    }
}
