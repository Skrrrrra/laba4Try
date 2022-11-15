using laba4Try.Roles;
using laba4Try.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4Try.DBContext
{
    public class AppContext:DbContext
    {
        public DbSet<User> UsersTable { get; set; }
        public DbSet<firstTable> FirstTable { get; set; }
        //public DbSet<SecondTable> SecondTable { get; set; }

        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
