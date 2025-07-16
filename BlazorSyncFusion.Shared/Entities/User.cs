using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorSyncFusion.Shared.Entities
{
    public class User
    {
        // columns in the database
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("Order Id")]
        public int? OrderId { get; set; }

        [Column("Customer ID")]
        public string? CustomerID { get; set; }

        [Column("Employee ID")]
        public int? EmployeeID { get; set; }

        [Column("Ship Village")]
        public string? ShipVillage { get; set; }

        [Column("Ryo Currency")]
        public decimal? RyoCurrency { get; set; }
    }
}
