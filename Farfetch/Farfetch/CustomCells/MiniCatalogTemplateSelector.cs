using Farfetch.DTO;
using Xamarin.Forms;

namespace Farfetch
{
	public class MiniCatalogTemplateSelector : DataTemplateSelector
	{
		public MiniCatalogTemplateSelector()
		{
			_defaultMiniCatalogViewCellTemplate = new DataTemplate(typeof(DefaultMiniCatalogViewCell));
			_lastMiniCatalogViewCellTemplate = new DataTemplate(typeof(LastMiniCatalogViewCell));

		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var catalog = item as Catalog;
			if (catalog == null) return null;
			return catalog.IsLastItem ? _lastMiniCatalogViewCellTemplate : _defaultMiniCatalogViewCellTemplate;
		}

		private readonly DataTemplate _defaultMiniCatalogViewCellTemplate;
		private readonly DataTemplate _lastMiniCatalogViewCellTemplate;
	}
}
