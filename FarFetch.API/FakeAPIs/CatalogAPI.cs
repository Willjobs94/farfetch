using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public class CatalogAPI : ICatalogAPI
	{
		public CatalogAPI()
		{
			_catalogs = new List<Catalog>
			{
					new Catalog
				{
					Title = "NEW IN TODAY",
					RightItemCatalog = new ItemCatalog
					{
						Name = "JACKET",
						ImageUri = "jacket",
						Price = 750
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "BAG",
						ImageUri = "bag",
						Price = 460
					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "BLOUSE",
						ImageUri = "blouse",
						Price = 950
					}
				},
				new Catalog
				{
					Title = "SUMMER 2016: THE HOT LIST",
					RightItemCatalog = new ItemCatalog
					{
						Name = "COURRÈGES",
						ImageUri = "courreges",
						Price = 705
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "CESARE PACIOTTI",
						ImageUri = "paciotti",
						Price = 562

					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "HOUSE OF HOLLAND",
						ImageUri = "houseofholland",
						Price = 388
					}
				},
				new Catalog
				{
					Title = "MODERN CRAFT",
					RightItemCatalog = new ItemCatalog
					{
						Name = "PINK BLOUSE",
						ImageUri = "pinkblouse",
						Price = 820
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "GOLD EARRINGS",
						ImageUri = "earrings",
						Price = 600

					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "BUSINESS SKIRT",
						ImageUri = "skirt",
						Price = 500
					},

				}


			};
		}

		public async Task<IEnumerable<Catalog>> GetRecentCatalogsAsync()
		{
			return  await Task.Run(() => _catalogs);
		}

		private readonly IEnumerable<Catalog> _catalogs;
	}
}
