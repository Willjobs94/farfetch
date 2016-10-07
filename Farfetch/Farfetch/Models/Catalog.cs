using System;
using System.Collections.Generic;

namespace Farfetch
{
	public class Catalog
	{
		public string Title { get; set; }
		public IEnumerable<ItemCatalog> Items { get; set;}
	}
}
