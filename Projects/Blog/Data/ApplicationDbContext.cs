using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// "Server=127.0.0.1;Database=blog;User=chan;Password=12345;"

namespace Blog.Data
{
    public class ApplicationDbContext:IdentityDbContext<UserModel>
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");

        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<CommentModel>Comment { get; set; }
        // public DbSet<FollowerModel>Follower { get; set; }
        public DbSet<TagModel>Tag { get; set; }
        public DbSet<PostTagModel>PostTag { get; set; }
    
    protected void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<UserModel>()
                .HasKey(u => u.UserId);

            // Post configuration
            modelBuilder.Entity<PostModel>()
                .HasKey(p => p.PostId);

            modelBuilder.Entity<PostModel>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);

            // Comment configuration
            modelBuilder.Entity<CommentModel>()
                .HasKey(c => c.CommentId);

            modelBuilder.Entity<CommentModel>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId);

            modelBuilder.Entity<CommentModel>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);

            // // Follower configuration
            // modelBuilder.Entity<FollowerModel>()
            //     .HasKey(f => f.FollowerId);

            // modelBuilder.Entity<FollowerModel>()
            //     .HasOne(f => f.User)
            //     .WithMany(u => u.Followers)
            //     .HasForeignKey(f => f.UserId)
            //     .OnDelete(DeleteBehavior.Restrict);  


            // modelBuilder.Entity<FollowerModel>()
            //     .HasOne(f => f.FollowingUser)
            //     .WithMany(u => u.Followers)
            //     .HasForeignKey(f => f.FollowingId)
            //     .OnDelete(DeleteBehavior.Restrict);  

            // Tag configuration
            modelBuilder.Entity<TagModel>()
                .HasKey(t => t.TagId);

            // PostTag configuration
            modelBuilder.Entity<PostTagModel>()
                .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<PostTagModel>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTagModel>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);
        }

    
    }

}