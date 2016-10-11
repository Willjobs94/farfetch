using System;
using System.Globalization;
using Xamarin.Forms;

namespace Farfetch
{
	public class FormatedStringConverter : IValueConverter
	{
		public FormatedStringConverter()
		{
		}

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
			if (!(value is FormattedString)) return value;
			var castedValue = (FormattedString)value;
			var text = castedValue.Spans[0].Text.Replace("$", "");
			var convertedText = -1;
			return Int32.TryParse(text, out convertedText);
		}
	}
}
