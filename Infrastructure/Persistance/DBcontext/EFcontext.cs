using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DBcontext
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options)
           : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Examinee> Examinees { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
