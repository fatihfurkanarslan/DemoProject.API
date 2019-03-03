using EntitiyLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
      
            //dbcontext options is derived from basecontext
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {

            }

            //generetes dbsets which are instances of tables of db
            public DbSet<User> Users { get; set; }
          

    }
}

