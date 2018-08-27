using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotnetCore_mvcModels__ShoppingList.Entities
{
   public partial class MyShopLiContext: DbContext
    {
        public virtual DbSet<ShopItem> ShopItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSQLLocalDB; Initial Catalog=MyShopLi; Integrated Security=True; ");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopItem>(entity =>
            {
                entity.Property(e => e.ID);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}

