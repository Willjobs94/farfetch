using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Farfetch.ViewModels
{
	public class ShopTabPageViewModel : BindableBase
	{
		public ShopTabPageViewModel()
		{
			Title = "SHOP";
		}

		public string Title { get; set; }
	}
}
