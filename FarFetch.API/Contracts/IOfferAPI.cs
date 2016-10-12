using System;
using System.Threading.Tasks;
using Farfetch;

namespace FarFetch.API
{
	public interface IOfferAPI
	{
		Task<Offer> GetTodayOfferAsync();
	}
}
