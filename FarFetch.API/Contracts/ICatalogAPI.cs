using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public interface ICatalogAPI
	{
		Task<IEnumerable<Catalog>> GetRecentCatalogs();
	}
}
