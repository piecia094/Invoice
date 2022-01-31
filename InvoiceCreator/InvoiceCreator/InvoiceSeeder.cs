using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceCreator.Entities;

namespace InvoiceCreator.Controllers
{
    public class InvoiceSeeder
	{
	    private readonly InvoiceDbContext _dbContext;
	    public InvoiceSeeder(InvoiceDbContext dbContext)
	    {
		    _dbContext = dbContext;
	    }

	    public void Seed()
	    {
		    if (_dbContext.Database.CanConnect())
		    {
			    if (!_dbContext.Client.Any())
			    {
				    var client = GetClient();
				    _dbContext.Client.AddRange(client);
				    _dbContext.SaveChanges();
				}

		    }
	    }

	    private IEnumerable<Client> GetClient()
	    {
		    var client = new List<Client>()
		    {
			    new Client()
			    {
					Name = "DZIKI",
					Klient = new Address()
					{
						City = "Warszawa",
						Country = "Polska",
						PostCode = 01160,
						Street = "Kochanowskiego",
						BuldingNumber = 19
					},
					Nip = "333333"			    }
		    };


		    return client;
	    }
    }
}
