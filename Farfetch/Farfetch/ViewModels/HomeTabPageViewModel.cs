using Prism.Mvvm;

namespace Farfetch.ViewModels
{
	public class HomeTabPageViewModel : BindableBase
	{
		public HomeTabPageViewModel()
		{
			Title = "Home";
			OfferTitle = "SALE | UP TO 50% OFF";
			OfferCategory = "ACCESSORIES";
			OfferImageUri = "accessories";

		}
		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		private string _offerTitle;
		public string OfferTitle
		{
			get { return _offerTitle; }
			set { SetProperty(ref _offerTitle, value); }
		}

		private string _offerCategory;
		public string OfferCategory
		{
			get { return _offerCategory; }
			set { SetProperty(ref _offerCategory, value); }
		}

		private string _offerImageUri;
		public string OfferImageUri
		{
			get { return _offerImageUri; }
			set { SetProperty(ref _offerImageUri, value); }
		}

	}
}
