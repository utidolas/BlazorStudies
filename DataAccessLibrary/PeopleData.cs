using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * from dbo.Orders"; // select all records from the Orders table
            return _db.LoadData<PersonModel, dynamic>(sql, new { }); // get all records from the Orders table
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"insert into dbo.Orders (CustomerID, EmployeeID, ShipVillage, RyoCurrency)
                           values (@CustomerID, @EmployeeID, @ShipVillage, @RyoCurrency)"; // insert a new record into the Orders table
            return _db.SaveData(sql, person); // save the new record to the Orders table
        }
    }
}
