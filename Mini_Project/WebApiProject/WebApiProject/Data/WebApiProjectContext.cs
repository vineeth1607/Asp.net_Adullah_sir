using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Model;

namespace WebApiProject.Data
{
    public class WebApiProjectContext : DbContext
    {
        public WebApiProjectContext (DbContextOptions<WebApiProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiProject.Model.Product> Product { get; set; }
    }
}
