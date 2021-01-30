using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleGumApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Apple" },
                new Category { Id = 2, Name = "Pink" },
                new Category { Id = 3, Name = "PineApple" },
                new Category { Id = 4, Name = "Stu" },
                new Category { Id = 5, Name = "Dirolled" },
                new Category { Id = 6, Name = "InterestingCategory" },
                new Category { Id = 9, Name = "Juicy" });

            modelBuilder.Entity<BubbleGum>().HasData(
                new BubbleGum { Id = 1, Name = "Diroll", Description = " a long ", Price = 99, CategoryId = 1, IsAvailable = true },
                new BubbleGum { Id = 2, Name = "Orbitt", Description = " a long description ", Price = 24, CategoryId = 2, IsAvailable = true },
                new BubbleGum { Id = 3, Name = "Baboll", Description = " and a short description ", Price = 12, CategoryId = 5, IsAvailable = true },
                new BubbleGum { Id = 4, Name = "Smash", Description = " a description ", Price = 56, CategoryId = 6, IsAvailable = true },
                new BubbleGum { Id = 5, Name = "Slesh", Description = " a long description ", Price = 639, CategoryId = 9, IsAvailable = false },
                new BubbleGum { Id = 6, Name = "Keva", Description = " hehe a long description ", Price = 94, CategoryId = 2, IsAvailable = true },
                new BubbleGum { Id = 7, Name = "Energy", Description = " something long description ", Price = 94, CategoryId = 2, IsAvailable = true },
                new BubbleGum { Id = 8, Name = "FlapTop", Description = " a very long description ", Price = 94431, CategoryId = 3, IsAvailable = true },
                new BubbleGum { Id = 9, Name = "CoolBeans", Description = " a short description ", Price = 10, CategoryId = 4, IsAvailable = false });
        }
    }
}
