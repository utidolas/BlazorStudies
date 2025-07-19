using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class OrdersData : IOrdersData
    {
        private readonly ISqlDataAccess _db;

        public OrdersData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OrderModel>> GetPeople()
        {
            string sql = "SELECT * from dbo.OrdersNoIDs"; // select all records from the OrdersNoIDs table
            return _db.LoadData<OrderModel, dynamic>(sql, new { }); // get all records from the OrdersNoIDs table
        }

        public Task InsertPerson(OrderModel order)
        {
            string sql = @"INSERT INTO dbo.OrdersNoIDs (CustomerName, ShipVillage, RyoCurrency)
                           VALUES (@CustomerName, @ShipVillage, @RyoCurrency)"; // insert a new record into the Orders table

            return _db.SaveData(sql, order); // save the new record to the Orders table
        }
    }
}
