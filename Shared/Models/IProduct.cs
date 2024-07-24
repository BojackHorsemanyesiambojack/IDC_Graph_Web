using System.ComponentModel.DataAnnotations;

namespace IDC_Web.Shared.Models
{
    public class IProduct
    {
        [Key]
        public int? product_id { get; set; }
        public string product_name { get; set; }
        public string product_material { get; set; }
        public string product_type { get; set; }
        public decimal product_price { get; set; }
        public int? product_stack { get; set; }
    }
}
