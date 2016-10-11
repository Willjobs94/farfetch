using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Prism.Navigation;
using FarFetch.API;

namespace Farfetch.ViewModels
{
	public class ItemDetailPageViewModel : BindableBase, INavigationAware
	{
		public ItemDetailPageViewModel(IShopItemAPI shopItemApi)
		{
			_shopItemApi = shopItemApi;

			Title = "DETAIL";
		}
		public string Title { get; set; }

		public string Brand
		{
			get { return _brand; }
			set { SetProperty(ref _brand, value); }
		}
		public string Name 
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}
			
		public string ImageUri
		{
			get { return _imageUri; }
			set { SetProperty(ref _imageUri, value); }
		}

		public string Description 
		{
			get { return _description; }
			set { SetProperty(ref _description, value); }
		}

		public decimal Price 
		{
			get { return _price; }
			set 
			{ 
				SetProperty(ref _price, value);
			}
		}

		public DelegateCommand AddToBagCommand { get; set; }


		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("id"))
			{
				var id = (int)parameters["id"];
				GetOneAsync(id);
			}
		}

		async void GetOneAsync(int id)
		{
			var model = await _shopItemApi.GetOneAsync(id);
			if (model == null) return;
			{
				Name = model.Name;
				Brand = model.Brand;
				Description = model.Description;
				ImageUri = model.ImageUri;
				Price = model.Price;
			}
		}

		private string _name;
		private string _brand;
		private string _imageUri;
		private string _description;
		private decimal _price;
		private FormattedString _customFomatedTex;

		private readonly IShopItemAPI _shopItemApi;
	}
}
