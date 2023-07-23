using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E.sunbank0721.Models
{
    public class Order
	{
        [Display(Name = "Order Item SN")]
        public int ID { get; set; }

        [Display(Name = "Order ID")]
        public string OrderID { get; set; } = string.Empty;
        [Display(Name = "Product ID")]
        public string ProductID { get; set; } = string.Empty;
        public int Quantity { get; set; }

        [Display(Name = "Stand Price")]
        public int StandPrice { get; set; }
        [Display(Name = "Item Price")]
        public int ItemPrice { get; set; }

        [Display(Name = "Member ID")]
        public int MemberID { get; set; }

        [Display(Name = "Pay Status")]
        public int PayStatus { get; set; } = 0;

    }
}
