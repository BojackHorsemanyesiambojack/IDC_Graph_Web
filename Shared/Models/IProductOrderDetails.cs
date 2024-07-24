using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IDC_Web.Shared.Models
{
    public class IProductOrderDetails
    {
        [Key]
        public int product_order_details_id { get; set; }
        [Required, NotNull]
        public int product_order_id { get; set; }
        [Required, NotNull]
        public decimal product_ammount { get; set; }
        [Required, NotNull]
        public int product_id { get; set; }
    }
}
