using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalCodebaseEvaluation.Model;

namespace FinalCodebaseEvaluation.Data
{
    public class FinalCodebaseEvaluationContext : DbContext
    {
        public FinalCodebaseEvaluationContext (DbContextOptions<FinalCodebaseEvaluationContext> options)
            : base(options)
        {
        }

        public DbSet<FinalCodebaseEvaluation.Model.Employee> Employee { get; set; }
    }
}
