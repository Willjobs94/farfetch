using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public class ShopItemAPI : IShopItemAPI
	{
		public ShopItemAPI()
		{
			_shopItemList = new List<ShopItem>
			{
				new ShopItem
				{
					LeftItem = new Item
					{
						Id = 1,
						Name = "Test sdf",
						Description = "Description placeholder",
						ImageUri = "blouse",
						Price = 234
					},
					RightItem = new Item
					{
						Id = 2,
						Name = "rigsts tsdfest",
						Description = "Description placeholder",
						ImageUri = "bag",
						Price = 234
					}
				},

				new ShopItem
				{
					LeftItem = new Item
					{
						Id = 3,
						Name = "Name test",
						Description = "Description placeholder",
						ImageUri = "courreges",
						Price = 234
					},
					RightItem = new Item
					{
						Id = 4,
						Name = "Name test",
						Description = "Description placeholder",
						ImageUri = "pinkblouse",
						Price = 234
					}
				}
			};

			_ItemList = new List<Item>
			{
				new Item
				{
					Id = 1,
					Name = "Test sdf",
					Brand = "NISOM",
					Description = _descriptionLoremIpsum,
					ImageUri = "blouse",
					Price = 234,

				},
				new Item
				{
					Id = 2,
					Name = "tu real bag",
					Brand = "Dolce&Gabbana".ToUpper(),
					Description = _descriptionLoremIpsum,
					ImageUri = "bag",
					Price = 234
				},
				new Item
				{
					Id = 3,
					Name = "the best jacket ",
					Brand = "COURRÈGES",
					Description = _descriptionLoremIpsum,
					ImageUri = "courreges",
					Price = 234
				},
				new Item
				{
					Id = 4,
					Name = "Name test",
					Brand = "MI MARCA",
					Description = _descriptionLoremIpsum,
					ImageUri = "pinkblouse",
					Price = 234
				}
			};
		}


		public async Task<IEnumerable<ShopItem>> GetAllAsync()
		{
			return await Task.Run(() => _shopItemList);
		}

		public async Task<Item> GetOneAsync(int id)
		{
			return await Task.Run(() => _ItemList.FirstOrDefault(i => i.Id == id));
		}

		private string _descriptionLoremIpsum = "Lorem ipsum dolor sit amet, consectetur " +
				"adipiscing elit. Duis a purus eu magna posuere porttitor " +
				"in a felis. Donec egestas, eros in scelerisque sodales, dui " +
				"est laoreet eros, nec cursus justo elit et ligula. entum eros " +
				"nisl, id accumsan quam lacinia quis. Morbi scelerisque " +
				"ornare neque sit amet interdum.";

		private IEnumerable<ShopItem> _shopItemList;
		private IEnumerable<Item> _ItemList;
	}
}
