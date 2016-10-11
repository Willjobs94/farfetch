using System;
using System.Threading.Tasks;
using Farfetch;

namespace FarFetch.API
{
	public class OfferAPI : IOfferAPI
	{
		public OfferAPI()
		{
			_todayOffer = new Offer
			{
				Title = "SALE | UP TO 50% OFF",
				Category = "ACCESSORIES",
				ImageUri = "accessories"
			};

		}

		public async Task<Offer> GetTodayOfferAsync()
		{
			return await Task.Run(() => _todayOffer);
		}

		private readonly Offer _todayOffer;

	}
}
