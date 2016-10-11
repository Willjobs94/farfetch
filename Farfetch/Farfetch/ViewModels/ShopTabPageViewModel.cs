using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Farfetch.DTO;

namespace Farfetch.ViewModels
{
	public class ShopTabPageViewModel : BindableBase
	{
		public ShopTabPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			ItemTappedCommand = new DelegateCommand<Item>(NavigateToItemDetailAsync);
			Title = "SHOP";
			ShopItems = new List<ShopItem>
			{
				new ShopItem
				{
					LeftItem = new Item
					{
						Name = "eftl 234233",
						Description = "Description placeholder",
						ImageUri = "blouse",
						Price = 234

					},
					RightItem = new Item
					{
						Name = "rigsts tsdfest",
						Description = "Description placeholder",
						ImageUri = "blouse",
						Price = 234

					}
				},

				new ShopItem
				{
					LeftItem = new Item
					{
						Name = "Name test",
						Description = "Description placeholder",
						ImageUri = "blouse",
						Price = 234

					},
					RightItem = new Item
					{
						Name = "Name test",
						Description = "Description placeholder",
						ImageUri = "blouse",
						Price = 234

					}
				}
			};
		}

		public DelegateCommand<Item> ItemTappedCommand { get; set; }
		public string Title { get; set; }
		public IEnumerable<ShopItem> ShopItems { get; set; }

		async void NavigateToItemDetailAsync(Item item)
		{
			await _navigationService.NavigateAsync("ItemDetailPage", null);
		}

		private INavigationService _navigationService;

	}
}