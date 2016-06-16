using MojSklep.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojSklep.DataAccess
{
    /// <summary>
    /// klasa odpowiedzialna za łączenie się aplikacji z bazą danych 
    /// </summary>
    class StoreContext : DbContext
    {
        /// <summary>
        /// W konstruktorze wskazana dodana do pliku app.config konfiguracja połączenia z serwerem bazy danych SQL Server
        /// </summary>
        public StoreContext()
            : base("SklepDbContext")
        { }
        public DbSet<Produkty> Products { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
