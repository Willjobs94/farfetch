using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Farfetch.DTO;
using FarFetch.API;

namespace Farfetch.ViewModels
{
	public class BoutiqueTabPageViewModel : BaseViewModel
	{
		public BoutiqueTabPageViewModel(INavigationService navigationService, IBoutiqueAPI boutiqueAPI)
		{
			_navigationService = navigationService;
			_boutiqueApi = boutiqueAPI;

			Title = "BOUTIQUES";

			GetBoutiqueAsync();
			GoToDetailPageCommand = new DelegateCommand(GoToDetailPageAsync);
		}

		public string BoutiquesCount
		{
			get { return _boutiquesCount; }
			set { SetProperty(ref _boutiquesCount, value); }
		}


		public IEnumerable<BoutiqueItem> Boutiques
		{
			get { return _boutiques; }
			set { SetProperty(ref _boutiques, value); }
		}

		public BoutiqueItem _selectedItem;
		public BoutiqueItem SelectedItem
		{
			get { return _selectedItem; }
			set { SetProperty(ref _selectedItem, value); }
		}

		public DelegateCommand GoToDetailPageCommand { get; set; }

		async void GetBoutiqueAsync()
		{
			Boutiques = await _boutiqueApi.GetAllAsync();
			BoutiquesCount = Boutiques.Count().ToString();
		}

		async void GoToDetailPageAsync()
		{
			var param = new NavigationParameters();
			param.Add("id", SelectedItem.Id);
			SelectedItem = null;
			await _navigationService.NavigateAsync("BoutiqueDetailPage", param, true);
		}

		private string _boutiquesCount;
		private IEnumerable<BoutiqueItem> _boutiques;
		private readonly INavigationService _navigationService;
		private readonly IBoutiqueAPI _boutiqueApi;
	}
}
