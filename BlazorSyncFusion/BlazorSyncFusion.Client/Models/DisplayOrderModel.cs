using System.ComponentModel.DataAnnotations;

namespace BlazorSyncFusion.Client.Models
{
    // front-end model for displaying orders
    public class DisplayOrderModel
    {
        public int OrderID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage ="Nome é muito grande")]
        [MinLength(5, ErrorMessage = "Nome é muito curto")]
        public string? CustomerName { get; set; }
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Local de envio é muito grande")]
        [MinLength(5, ErrorMessage = "Local de envio é muito curto")]
        public string? ShipVillage { get; set; }
        public decimal RyoCurrency { get; set; }
    }
}
