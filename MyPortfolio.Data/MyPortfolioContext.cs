using Microsoft.EntityFrameworkCore;
using MyPortoflio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Data
{
    public class MyPortfolioContext: DbContext
    {
        
            public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options)
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
                        FullName = "Marlin Shenoda",
                        Profil = "Microsoft MVC / .NET Consultant"
                    }
                    );
            }

            public DbSet<Owner> Owner { get; set; }
            public DbSet<PortfolioItem> PortfolioItems { get; set; }
        }
    }

