using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms;
using Farfetch.DTO;

namespace Farfetch.ViewModels
{
	public class BoutiqueTabPageViewModel : BindableBase
	{
		public BoutiqueTabPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			Title = "BOUTIQUES";

			Boutiques = new List<Boutique>
			{
				new Boutique
				{
					ImageUri = "launchscreen",
					Name = "11 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				},
				new Boutique
				{
					ImageUri = "launchscreen",
					Name = "12 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				},
				new Boutique
				{
					ImageUri = "launchscreen",
					Name = "13 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				}
			};

			BoutiquesCount = Boutiques.Count().ToString();
			GoToDetailPageCommand = new DelegateCommand(GoToDetailPageAsync);
		}


		private string _boutiquesCount;
		public string BoutiquesCount
		{
			get { return _boutiquesCount; }
			set { SetProperty(ref _boutiquesCount, value); }
		}

		public string Title { get; set; }

		public IEnumerable<Boutique> Boutiques { get; set; }

		public Boutique _selectedItem;
		public Boutique SelectedItem
		{
			get { return _selectedItem; }
			set { SetProperty(ref _selectedItem, value); }
		}

		public DelegateCommand GoToDetailPageCommand { get; set; }

		async void GoToDetailPageAsync()
		{
			SelectedItem = null;
			await _navigationService.NavigateAsync("BoutiqueDetailPage", null, true);			
		}

		private INavigationService _navigationService;

	}
}
