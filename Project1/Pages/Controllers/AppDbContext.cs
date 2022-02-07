using Microsoft.EntityFrameworkCore;

namespace Project1.Pages.Controllers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        
        }
        public DbSet<MatchDay> Days { get; set; }
        public DbSet<Teams> Teams { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed Matchday Table
            modelBuilder.Entity<MatchDay>().HasData(
                new MatchDay { DayId = 1, DayName = "Monday" }
                );
            modelBuilder.Entity<MatchDay>().HasData(
                new MatchDay { DayId = 2, DayName = "Tuesday" }
                );
            modelBuilder.Entity<MatchDay>().HasData(
                new MatchDay { DayId = 3, DayName = "Saturday" }
                );
            modelBuilder.Entity<MatchDay>().HasData(
                new MatchDay { DayId = 4, DayName = "Sunday" }
                );


            //Seed Teams Table
            modelBuilder.Entity<Teams>().HasData(
                new Teams
                {
                    TeamId = 1,
                    TeamName = "Liverpool",
                    Verses = "ManCity",
                    Score = "Liverpool 2: ManCity 0",
                }
                );
            modelBuilder.Entity<Teams>().HasData(
               new Teams
               {
                   TeamId = 2,
                   TeamName = "ManU",
                   Verses = "Liverpool",
                   Score = "ManU 2: Liverpool",
               }
               );
            modelBuilder.Entity<Teams>().HasData(
               new Teams
               {
                   TeamId = 3,
                   TeamName = "Mancity",
                   Verses = "Newcastle",
                   Score = "ManCity 5: Newcastle 2",
               }
               );
            modelBuilder.Entity<Teams>().HasData(
               new Teams
               {
                   TeamId = 4,
                   TeamName = "Chiefs",
                   Verses = "Pirates",
                   Score = "Chiefs 0: Pirates",
               }
               );


        }
    }
}
