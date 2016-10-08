using Prism.Unity;
using Farfetch.Views;
using Xamarin.Forms;

namespace Farfetch
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MainPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<HomeTabPage>();
			Container.RegisterTypeForNavigation<BoutiqueTabPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainTabbedPage>();
		}


	}
}
