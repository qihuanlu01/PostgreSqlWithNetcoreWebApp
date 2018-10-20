using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostgreSqlWithNetcoreWebApp.Models
{
    public class PostgreSqlWithNetcoreWebAppContext : DbContext
    {
        public PostgreSqlWithNetcoreWebAppContext (DbContextOptions<PostgreSqlWithNetcoreWebAppContext> options)
            : base(options)
        {

        }

        public DbSet<PostgreSqlWithNetcoreWebApp.Models.Movie> Movie { get; set; }
    }
}
