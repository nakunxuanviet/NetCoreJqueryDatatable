using Microsoft.EntityFrameworkCore;
using NetCoreJqueryDatatable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreJqueryDatatable.Data
{
    public class DatatableContext : DbContext
    {
        public DatatableContext(DbContextOptions<DatatableContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
