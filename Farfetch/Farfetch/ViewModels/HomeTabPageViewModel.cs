using System.Collections.Generic;
using System.Linq;
using Prism.Mvvm;

namespace Farfetch.ViewModels
{
	public class HomeTabPageViewModel : BindableBase
	{
		public HomeTabPageViewModel()
		{
			Title = "Home";
			Offer = new Offer
			{
				Title = "SALE | UP TO 50% OFF",
				Category = "ACCESSORIES",
				ImageUri = "accessories"
			};

			Catalogs = new List<Catalog>
			{
					new Catalog
				{
					Title = "NEW IN TODAY",
					RightItemCatalog = new ItemCatalog
					{
						Name = "JACKET",
						ImageUri = "jacket",
						Price = "$750"
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "BAG",
						ImageUri = "bag",
						Price = "$460"
					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "BLOUSE",
						ImageUri = "blouse",
						Price = "$950"
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
						Price = "$388"
					}
				},
				new Catalog
				{
					Title = "MODERN CRAFT",
					RightItemCatalog = new ItemCatalog
					{
						Name = "PINK BLOUSE",
						ImageUri = "pinkblouse",
						Price = "$820"
					},
					CenterItemCatalog = new ItemCatalog
					{
						Name = "GOLD EARRINGS",
						ImageUri = "earrings",
						Price = "$600"

					},
					LeftItemCatalog = new ItemCatalog
					{
						Name = "BUSINESS SKIRT",
						ImageUri = "skirt",
						Price = "$500",
					},

				}
			

			};

			Catalogs.Last().IsLastItem = true;

		}

		public string Title { get; set; }
		public Offer Offer { get; set; }

		public IEnumerable<Catalog> Catalogs { get; set; }

	}
}
