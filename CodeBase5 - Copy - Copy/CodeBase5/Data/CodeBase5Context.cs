using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBase5.Models;

namespace CodeBase5.Data
{
    public class CodeBase5Context : DbContext
    {
        public CodeBase5Context (DbContextOptions<CodeBase5Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBase5.Models.Student> Student { get; set; }
    }
}
