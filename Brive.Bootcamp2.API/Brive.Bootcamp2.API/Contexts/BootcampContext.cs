using Brive.Bootcamp2.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Contexts
{
    public class BootcampContext : DbContext
    {
        public BootcampContext(DbContextOptions<BootcampContext> options): base(options) { }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Person>(eb =>
            {
                eb.HasKey(x => new { x.Id });
                });
        }
        public DbSet<Person> Person { get; set; }

      }
    }

