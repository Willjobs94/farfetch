using FarFetch.API;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Farfetch.ViewModels
{
	public class BoutiqueDetailPageViewModel : BaseViewModel, INavigationAware
	{
		public BoutiqueDetailPageViewModel(INavigationService navigationService, IBoutiqueAPI boutiqueApi)
		{
			_navigationService = navigationService;
			_boutiqueApi = boutiqueApi;
			IsBusy = true;
			CloseCommand = new DelegateCommand(ClosePageAsync);
		}

		public string Name
		{
			get { return _name; }
			set { SetProperty(ref _name, value); }
		}
		public string Address
		{
			get { return _address; }
			set { SetProperty(ref _address, value); }
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

		public DelegateCommand CloseCommand { get; set; }

		async void ClosePageAsync()
		{
			await _navigationService.GoBackAsync();
		}

		async void GetOneAsync(int id)
		{
			var model = await _boutiqueApi.GetOneAsync(id);
			if (model == null) return;
			Name = model.Name;
			Description = model.Description;
			Address = model.Address;
			ImageUri = model.ImageUri;
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			var id = (int)parameters["id"];
			GetOneAsync(id);
			IsBusy = false;
		}

		private string _name;
		private string _address;
		private string _imageUri;
		private string _description;

		private readonly INavigationService _navigationService;
		private readonly IBoutiqueAPI _boutiqueApi;
	}
}
