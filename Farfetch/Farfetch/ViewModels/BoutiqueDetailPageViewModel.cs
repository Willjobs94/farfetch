using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Farfetch.ViewModels
{
	public class BoutiqueDetailPageViewModel : BindableBase
	{
		public BoutiqueDetailPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			CloseCommand = new DelegateCommand(ClosePageAsync);

			Name = "11 Boris Bidjan Saberi New York";
			Address = "455 Greenwish Street, New York, United States";
			ImageUri = "launchscreen";
			Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
				"In diam est, tincidunt et lacus quis, luctus pellentesque dolor. Curabitur " +
				"porttitor feugiat purus. Morbi efficitur vestibulum purus, a posuere magna. " +
				"Sed et egestas libero. Morbi aliquet quam sit amet diam tempor, ut aliquet " +
				"lectus pretium. Ut massa justo, dictum eu ipsum pharetra, sollicitudin suscipit " +
				"metus. Maecenas in ullamcorper eros, ac ultricies dui. Proin quis nisi lacus. Cras " +
				"porttitor neque nec aliquet laoreet.";
		}

		public string Name { get; set; }
		public string Address { get; set; }
		public string ImageUri { get; set; }
		public string Description { get; set; }

		public DelegateCommand CloseCommand { get; set; }

		async void ClosePageAsync()
		{
			await _navigationService.GoBackAsync();
		}

		private INavigationService _navigationService;
	}
}
