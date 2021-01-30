using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleGumApi.Models
{
    public class BubbleGumContext : DbContext
    {
        // Options are coming from Startup.CS file
        // services.AddDbContext<BubbleGumContext>(options => options.UseInMemoryDatabase("gum-ball"));
        public BubbleGumContext(DbContextOptions<BubbleGumContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(category => category.bubbleGums)
                .WithOne(bubblegum => bubblegum.Category)
                .HasForeignKey(bubbleGum => bubbleGum.CategoryId);

            modelBuilder.Seed();
        }

        public DbSet<BubbleGum> bubbleGums { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
