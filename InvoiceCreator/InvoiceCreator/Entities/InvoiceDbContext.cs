using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace InvoiceCreator.Entities
{
    public class InvoiceDbContext : DbContext
    {
	    private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=InvoiceDb;Trusted_Connection=True;";
		public DbSet<Address> Address { get; set; }
		public DbSet<Client> Client { get; set; }
		public DbSet<Invoice> Invoice { get; set; }
		public DbSet<Item> Item { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuildder)
		{
			modelBuildder.Entity<Address>()
				.Property(x => x.City)
				.IsRequired();
			modelBuildder.Entity<Invoice>()
				.Property(x => x.Id)
				.IsRequired();
			modelBuildder.Entity<Client>()
				.Property(x => x.Nip)
				.IsRequired();
			modelBuildder.Entity<Item>()
				.Property(x => x.ProductName)
				.IsRequired();
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
		}
	}
}
