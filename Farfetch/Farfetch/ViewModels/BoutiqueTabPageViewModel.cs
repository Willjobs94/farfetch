using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

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
					Name = "11 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				},
				new Boutique
				{
					ImageUri = "launchscreen",
					Name = "11 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				}
			};

			BoutiquesCount = Boutiques.Count().ToString();
			ItemTappedCommand = new DelegateCommand(OnItemTapped);
		}

		private string _boutiquesCount;
		public string BoutiquesCount
		{
			get { return _boutiquesCount;}
			set { SetProperty(ref _boutiquesCount, value); }
		}

		public string Title { get; set; }

		public IEnumerable<Boutique> Boutiques { get; set; }

		public DelegateCommand ItemTappedCommand { get; set; }

		void OnItemTapped()
		{
			_navigationService.NavigateAsync("BoutiqueDetailPage");
		}

		private INavigationService _navigationService;

	}
}
