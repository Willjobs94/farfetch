namespace Farfetch.DTO
{
	public class Catalog
	{
		public string Title { get; set; }
		public ItemCatalog RightItemCatalog { get; set; }
		public ItemCatalog CenterItemCatalog { get; set; }
		public ItemCatalog LeftItemCatalog { get; set; }
		public bool IsLastItem { get; set; }
	}
}
