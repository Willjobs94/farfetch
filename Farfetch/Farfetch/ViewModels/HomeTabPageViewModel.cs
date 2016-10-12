using System.Collections.Generic;
using System.Linq;
using Farfetch.DTO;
using FarFetch.API;
using Prism.Mvvm;

namespace Farfetch.ViewModels
{
	public class HomeTabPageViewModel : BindableBase
	{
		public HomeTabPageViewModel(ICatalogAPI catalogApi, IOfferAPI offerApi)
		{
			_catalogApi = catalogApi;
			_offerApi = offerApi;

			Title = "Home";

			GetTodayOfferAsync();
			GetCatalogsAsync();
		}

		public string Title { get; set; }

		public Offer Offer
		{
			get { return _offer; }
			set { SetProperty(ref _offer, value); }
		}

		public IEnumerable<Catalog> Catalogs
		{
			get { return _catalogs; }
			set { SetProperty(ref _catalogs, value); }
		}

		async void GetTodayOfferAsync()
		{
			Offer = await _offerApi.GetTodayOfferAsync();
		}

		async void GetCatalogsAsync()
		{
			Catalogs = await _catalogApi.GetRecentCatalogsAsync();
			Catalogs.Last().IsLastItem = true;
		}

		private Offer _offer;
		private IEnumerable<Catalog> _catalogs;
		private readonly ICatalogAPI _catalogApi;
		private readonly IOfferAPI _offerApi;
	}
}
