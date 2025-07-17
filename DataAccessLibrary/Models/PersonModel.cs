using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PersonModel
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; } 
        public int EmployeeID { get; set; } 
        public string ShipVillage { get; set; }
        public decimal RyoCurrency { get; set; }

    }
}
