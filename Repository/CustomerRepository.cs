using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore.Repository
{

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomersDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Customer>> GetCustomersWithState()
        {
            return await GetContext().OrderBy(c => c.LastName).Include(c => c.State).ToListAsync();
        }
    }
}