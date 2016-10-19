using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Farfetch.DTO;
using FarFetch.API;

namespace Farfetch.ViewModels
{
	public class ShopTabPageViewModel : BaseViewModel
	{
		public ShopTabPageViewModel(INavigationService navigationService, IShopItemAPI shopItemApi)
		{
			_navigationService = navigationService;
			_shopItemApi = shopItemApi;

			Title = "SHOP";

			ItemTappedCommand = new DelegateCommand<Item>(NavigateToItemDetailAsync);
			GetShopItemListAsync();
		}

		public DelegateCommand<Item> ItemTappedCommand { get; set; }

		public IEnumerable<ShopItem> ShopItems
		{
			get { return _shopItems; }
			set { SetProperty(ref _shopItems, value); }
		}

		async void GetShopItemListAsync()
		{
			ShopItems = await _shopItemApi.GetAllAsync();
		}

		async void NavigateToItemDetailAsync(Item item)
		{
			var param = new NavigationParameters();
			param.Add("id", item.Id);
			await _navigationService.NavigateAsync("ItemDetailPage", param);
		}

		private IEnumerable<ShopItem> _shopItems;
		private readonly INavigationService _navigationService;
		private readonly IShopItemAPI _shopItemApi;
	}
}