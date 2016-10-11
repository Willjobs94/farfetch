using Prism.Unity;
using Farfetch.Views;
using Xamarin.Forms;
using FarFetch.API;
using Microsoft.Practices.Unity;

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
			Container.RegisterTypeForNavigation<BoutiqueDetailPage>();
			Container.RegisterTypeForNavigation<ItemDetailPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();

			Container.RegisterTypeForNavigation<MainTabbedPage>();
			Container.RegisterTypeForNavigation<HomeTabPage>();
			Container.RegisterTypeForNavigation<ShopTabPage>();
			Container.RegisterTypeForNavigation<BoutiqueTabPage>();

			Container.RegisterType<IBoutiqueAPI, BoutiqueAPI>();
			Container.RegisterType<IShopItemAPI, ShopItemAPI>();
			Container.RegisterType<ICatalogAPI, CatalogAPI>();
			Container.RegisterType<IOfferAPI, OfferAPI>();
		}
	}
}
