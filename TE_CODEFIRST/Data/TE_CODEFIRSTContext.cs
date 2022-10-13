using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TE_CODEFIRST.Models;

namespace TE_CODEFIRST.Data
{
    public class TE_CODEFIRSTContext : DbContext
    {
        public TE_CODEFIRSTContext (DbContextOptions<TE_CODEFIRSTContext> options)
            : base(options)
        {
        }

        public DbSet<TE_CODEFIRST.Models.Trainee> Trainee { get; set; } = default!;
    }
}
