using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Farfetch.ViewModels
{
	public class ItemDetailPageViewModel : BindableBase
	{
		public ItemDetailPageViewModel()
		{
			Title = "DETAIL";
			Description = "Lorem ipsum dolor sit amet, consectetur " +
				"adipiscing elit. Duis a purus eu magna posuere porttitor " +
				"in a felis. Donec egestas, eros in scelerisque sodales, dui " +
				"est laoreet eros, nec cursus justo elit et ligula. entum eros " +
				"nisl, id accumsan quam lacinia quis. Morbi scelerisque " +
				"ornare neque sit amet interdum.";
			ImageUri = "jacket";
			Brand = "COURRÈGES";
			Name = "denim jacket";
			Price = 234;
		}

		public string Title { get; set; }
		public string Brand { get; set; }
		public string Name { get; set; }
		public string ImageUri { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public DelegateCommand AddToBagCommand { get; set; }

		public FormattedString CustomFormattedText
		{
			get
			{
				return new FormattedString
				{
					Spans =
					{
						new Span
						{
							Text = "$" + Price,
							ForegroundColor = Color.Black,
							FontSize = 13 
						},
						new Span
						{
							ForegroundColor = Color.FromHex("#878787"),
							Text = " (Import duties included)",
							FontSize = 10
						}
					}
				};
			}
		}
	}
}
