using System;
using System.Globalization;
using Xamarin.Forms;

namespace Farfetch
{
	public class DecimalValueConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is decimal)) return value;
			return "$" + value;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
