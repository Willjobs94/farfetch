using System.Collections.Generic;
using Prism.Mvvm;

namespace Farfetch.ViewModels
{
	public class HomeTabPageViewModel : BindableBase
	{
		public HomeTabPageViewModel()
		{
			Title = "Home";
			OfferTitle = "SALE | UP TO 50% OFF";
			OfferCategory = "ACCESSORIES";
			OfferImageUri = "accessories";

			Catalog = new Catalog
			{
				Title = "NEW IN NEW YORK",
				Items = new List<ItemCatalog>
					{
						new ItemCatalog
						{
							Name = "JACKET",
							ImageUri = "jacket",
							Price = "$750"
						},
						new ItemCatalog
						{
							Name = "BAG",
							ImageUri = "bag",
							Price = "$750"
						},
						new ItemCatalog
						{
							Name = "BLOUSE",
							ImageUri = "blouse",
							Price = "$750"
						}
					}
			};
		}

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private string _offerTitle;
		public string OfferTitle
		{
			get { return _offerTitle; }
			set { SetProperty(ref _offerTitle, value); }
		}

		private string _offerCategory;
		public string OfferCategory
		{
			get { return _offerCategory; }
			set { SetProperty(ref _offerCategory, value); }
		}

		private string _offerImageUri;
		public string OfferImageUri
		{
			get { return _offerImageUri; }
			set { SetProperty(ref _offerImageUri, value); }
		}

		public Catalog Catalog { get; set; }

	}
}
