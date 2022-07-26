using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DatabaseContext :DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=VIKUM\SQLEXPRESS;Initial Catalog=exam4;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }
        public DbSet<Seller> Sellers { get; set; }
    }
}
