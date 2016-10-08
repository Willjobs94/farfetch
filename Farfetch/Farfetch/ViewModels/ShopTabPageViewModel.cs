using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Farfetch.ViewModels
{
	public class ShopTabPageViewModel : BindableBase
	{
		public ShopTabPageViewModel()
		{
			Title = "SHOP";
			Catalogs = new List<Catalog>
			{
				new Catalog
				{
					Title = "SUMMER 2016: THE HOT LIST",
					RightItemCatalog = new ItemCatalog
					{
						Name = "COURRÈGES",
						ImageUri = "courreges",
						Price = "$705"
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "CESARE PACIOTTI",
						ImageUri = "paciotti",
						Price = "$562"

					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "HOUSE OF HOLLAND",
						ImageUri = "houseofholland",
						Price = "$388"
					}
				},
				new Catalog
				{
					Title = "SUMMER 2016: THE HOT LIST",
					RightItemCatalog = new ItemCatalog
					{
						Name = "COURRÈGES",
						ImageUri = "courreges",
						Price = "$705"
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "CESARE PACIOTTI",
						ImageUri = "paciotti",
						Price = "$562"

					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "HOUSE OF HOLLAND",
						ImageUri = "houseofholland",
						Price = "$388",
					},
					IsLastItem = true

				}
			};

		}

		public string Title { get; set; }
		public IEnumerable<Catalog> Catalogs { get; set; }
	}
}
