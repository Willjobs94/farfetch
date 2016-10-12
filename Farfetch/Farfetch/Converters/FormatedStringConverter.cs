using System;
using System.Globalization;
using Xamarin.Forms;

namespace Farfetch
{
	public class FormatedStringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			return new FormattedString
			{
				Spans =
					{
						new Span
						{
							Text = "$" + value,
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

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new NotImplementedException();
		}
	}
}
