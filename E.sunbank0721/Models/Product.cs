using System.ComponentModel.DataAnnotations;

namespace E.sunbank0721.Models
{
	public class Product
	{
		public int ID { get; set; }

		[Display(Name = "Product ID")]
		public string ProductID { get; set; } = string.Empty;
		[Display(Name = "Product Name")]
		public string Product_Name { get; set; } = string.Empty;
		public int Price { get; set; }
		public int Quantity { get; set; }

	}
}
