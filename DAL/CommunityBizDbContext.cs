using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CommunityBizDbContext : DbContext
    {
        public CommunityBizDbContext(DbContextOptions<CommunityBizDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Business> Businesss { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<RecommendationImage> RecommendationsImage { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // מניעת שגיאת Multiple Cascade Paths ב-SQL Server:
            // כאשר מוחקים משתמש, לא למחוק אוטומטית את ההמלצות שכתב (Restrict)
            modelBuilder.Entity<Recommendation>()
                .HasOne(r => r.Recommeder)
                .WithMany(u => u.Recommendations)
                .HasForeignKey(r => r.RecommenderId)
                .OnDelete(DeleteBehavior.Restrict);

            // שמירת ה-Enum כמספר שלם (4, 5, 6) במסד הנתונים
            modelBuilder.Entity<Recommendation>()
                .Property(r => r.Rating)
                .HasConversion<int>();
        }
    }
}
