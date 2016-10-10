using System;
using Prism.Commands;
using Prism.Mvvm;

namespace Farfetch
{
	public class Item 
	{
		public Item()
		{
			ItemTappedCommand = new DelegateCommand(TestMethod);
		}

		public string Name { get; set; }
		public decimal Price { get; set; }
		public string ImageUri { get; set; }
		public string Description { get; set; }
		public bool IsStarred { get; set; }
		public DelegateCommand ItemTappedCommand { get; set; }


		void TestMethod()
		{
			var name = Name;
			throw new NotImplementedException();
		}

	}
}
