using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farfetch.DTO;

namespace FarFetch.API
{
	public class BoutiqueAPI : IBoutiqueAPI
	{
		public BoutiqueAPI()
		{
			_boutiqueItemList = new List<BoutiqueItem>
			{
				new BoutiqueItem
				{
					Id = 1,
					ImageUri = "borisbidjansaberi",
					Name = "11 BY BORIS BIDJAN SABERI NEW YORK",
					ShortAddress = "New York, United States"
				},
				new BoutiqueItem
				{
					Id = 2,
					ImageUri = "13metricuatri",
					Name = "13 METRI CUATRI",
					ShortAddress = "Bellaria, Italy"
				},
				new BoutiqueItem
				{
					Id = 3,
					ImageUri = "brownsfashion",
					Name = "BROWNS FASHION",
					ShortAddress = "London, United Kingdom"
				}
			};
			_boutiqueList = new List<Boutique>
			{
				new Boutique
				{
					Id = 1,
					ImageUri = "borisbidjansaberi",
					Name = "11 BY BORIS BIDJAN SABERI NEW YORK",
					Address = "455 GreenwisNew York, United States",
					Description = loremIpsumDescription
				},
				new Boutique
				{
					Id = 2,
					ImageUri = "13metricuatri",
					Name = "13 Metri Catri",
					Address = "Via Guidi Paolo, 102, 47814 Bellaria RN, Italy",
					Description = loremIpsumDescription
						
				},
				new Boutique
				{
					Id = 3,
					ImageUri = "brownsfashion",
					Name = "Browns Fashion",
					Address = "24-27 South Molton Street, London W1K 5RD, United Kingdom",
					Description = loremIpsumDescription
				}
			};

		}

		public async Task<IEnumerable<BoutiqueItem>> GetAllAsync()
		{
			return await Task.Run(() => _boutiqueItemList);
		}

		public async Task<Boutique> GetOneAsync(int id)
		{
			return await Task.Run(() => _boutiqueList.FirstOrDefault(i => i.Id == id));
		}

		private readonly IEnumerable<BoutiqueItem> _boutiqueItemList;
		private readonly IEnumerable<Boutique> _boutiqueList;
		private readonly string loremIpsumDescription = "Lorem ipsum dolor sit amet, consectetur " +
				"adipiscing elit. Duis a purus eu magna posuere porttitor " +
				"in a felis. Donec egestas, eros in scelerisque sodales, dui " +
				"est laoreet eros, nec cursus justo elit et ligula. entum eros " +
				"nisl, id accumsan quam lacinia quis. Morbi scelerisque " +
				"ornare neque sit amet interdum.";
	}
}
