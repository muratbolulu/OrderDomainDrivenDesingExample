﻿using Order.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repository
{
    public class OrderRepository : IBuyerRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }
}
