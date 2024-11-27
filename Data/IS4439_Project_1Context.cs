using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IS4439_Project_1.Models;

namespace IS4439_Project_1.Data
{
    public class IS4439_Project_1Context : IdentityDbContext
    {
        public IS4439_Project_1Context (DbContextOptions<IS4439_Project_1Context> options)
            : base(options)
        {
        }

        public DbSet<IS4439_Project_1.Models.Game> Game { get; set; } = default!;

        public DbSet<IS4439_Project_1.Models.Developer> Developer { get; set; } = default!;

    }
}
