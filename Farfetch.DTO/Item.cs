namespace Farfetch.DTO
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string ImageUri { get; set; }
		public string Description { get; set; }
		public bool IsStarred { get; set; }
	}
}
