using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore.Models;

namespace dotnetcore.Repository
{
    public interface ICustomerRepository : Repository.IRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomersWithState();
    }
}