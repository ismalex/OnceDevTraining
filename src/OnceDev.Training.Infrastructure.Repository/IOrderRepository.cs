﻿using OnceDev.Training.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnceDev.Training.Infrastructure.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> ListWithOrderItemsAsync();
        
     }
}