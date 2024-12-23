﻿using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace RestaurantManagement.Data
{
    public class RestaurantManagementContext : DbContext
    {
            public RestaurantManagementContext(DbContextOptions<RestaurantManagementContext> options) : base(options) { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Table> Tables { get; set; }
    }
}
