using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.Models
{
    public class MSDBContext:DbContext
    {
        public DbSet<TBL_Users> TBL_Users { get; set; }
        public DbSet<VerifyAccount> VerifyAccounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConnection.ConnectionStr);
        }
    }
}
