using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPortoflio.Core.Entities;

    public class MyPortolioContext : DbContext
    {
        public MyPortolioContext (DbContextOptions<MyPortolioContext> options)
            : base(options)
        {
        }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Owner>().HasData(
            new Owner()
            {
                Id = Guid.NewGuid(),
                Avatar = "M.jpg",
                FullName = "Khalid ESSAADANI",
                Profil = "Microsoft MVP / .NET Consultant"
            }
            );
    }
    public DbSet<MyPortoflio.Core.Entities.Owner> Owner { get; set; } = default!;

        public DbSet<MyPortoflio.Core.Entities.PortfolioItem> PortfolioItem { get; set; }
    }
