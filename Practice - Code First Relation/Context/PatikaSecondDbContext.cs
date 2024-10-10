using Microsoft.EntityFrameworkCore;
using Practice___Code_First_Relation.Entities;

namespace Practice___Code_First_Relation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PostEntity>()
                .HasOne(x => x.User)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.UserId);

        }

        DbSet<UserEntity> Users => Set <UserEntity>();
        DbSet<PostEntity> Posts => Set <PostEntity>();
    }
}
