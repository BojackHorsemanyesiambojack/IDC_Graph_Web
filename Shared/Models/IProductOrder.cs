using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IDC_Web.Shared.Models
{
    public class IProductOrder
    {
        [Key]
        public int product_order_id { get; set; }
        [Required, NotNull]
        public string product_order_client_name { get; set; }
        [Required, NotNull]
        public DateOnly product_order_date { get; set; }
        [Required, NotNull]
        public Decimal product_order_total_ammount { get; set; }
    }
}
