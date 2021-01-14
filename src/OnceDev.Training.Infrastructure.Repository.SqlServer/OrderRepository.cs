using Microsoft.EntityFrameworkCore;
using OnceDev.Training.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnceDev.Training.Infrastructure.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(NorthwindDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> ListWithOrderItemsAsync()
        {
            return await _context.Orders.Include(o => o.OrderItems).ToListAsync();
            // throw new NotImplementedException();
        }
    }
}
