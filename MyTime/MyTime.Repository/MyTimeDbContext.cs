using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyTime.Domain;
using MyTime.Repository.Mappping;

namespace MyTime.Repository
{
    public partial class MyTimeDbContext : DbContext
    {
        public MyTimeDbContext() { }

        public MyTimeDbContext(DbContextOptions<MyTimeDbContext> options) : base(options) { }

        public DbSet<TBLUser> TBLUser { get; set; }
        public DbSet<TBLTask> TBLTask { get; set; }
        public DbSet<TBLAppointment> TBLAppointment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new TBLUserMap(modelBuilder.Entity<TBLUser>());
            new TBLTaskMap(modelBuilder.Entity<TBLTask>());
            new TBLAppointmentMap(modelBuilder.Entity<TBLAppointment>());
        }
    }
}
