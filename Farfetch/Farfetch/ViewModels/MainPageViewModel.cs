using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace Farfetch.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			SignInCommand = new DelegateCommand(NavigateToTabbedPageAsync);
			RegisterCommand = new DelegateCommand(NavigateToTabbedPageAsync);

		}

		public DelegateCommand SignInCommand { get; set; }
		public DelegateCommand RegisterCommand { get; set; }

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		async void NavigateToTabbedPageAsync()
		{
			await _navigationService.NavigateAsync("MainTabbedPage");
		}

		private INavigationService _navigationService;
	}
}
