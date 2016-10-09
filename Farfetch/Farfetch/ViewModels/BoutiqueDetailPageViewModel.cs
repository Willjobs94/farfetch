using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Farfetch.ViewModels
{
	public class BoutiqueDetailPageViewModel : BindableBase
	{
		public BoutiqueDetailPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			CloseCommand = new DelegateCommand(ClosePage);
		}

		public DelegateCommand CloseCommand { get; set; }

		void ClosePage()
		{
			_navigationService.GoBackAsync();
		}

		private INavigationService _navigationService;
	}
}
