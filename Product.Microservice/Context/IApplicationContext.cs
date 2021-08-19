﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Microservice.Context
{
    public interface IApplicationContext
    {
        DbSet<Models.Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}
