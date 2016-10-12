using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public interface IBoutiqueAPI
	{
		Task<IEnumerable<BoutiqueItem>> GetAllAsync();

		Task<Boutique> GetOneAsync(int id);
	}
}
