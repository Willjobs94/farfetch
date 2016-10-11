using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public interface IShopItemAPI
	{
		Task<IEnumerable<ShopItem>> GetAll();

		Task<Item> GetOne(int id);
	}
}
