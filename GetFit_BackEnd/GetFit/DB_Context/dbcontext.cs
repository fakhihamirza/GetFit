using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetFit.DB_Context
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> Options) : base(Options)
        {
        }
        public DbSet<User> User{ get; set; } //makes a db table named user
        public DbSet<UserHistory> UserHistory { get; set; }
    }
}
