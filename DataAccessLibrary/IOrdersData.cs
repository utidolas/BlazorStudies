using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IOrdersData
    {
        Task<List<OrderModel>> GetPeople();
        Task InsertPerson(OrderModel person);
    }
}