
using Microsoft.EntityFrameworkCore;
using SocialmMedia.Models;

namespace SocialmMedia.Data
{
    
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=127.0.0.1;Database=socialmedia;User=chan;Password=chan1234;", 
                    new MySqlServerVersion(new Version(8, 0, 27)),
                    options => options.EnableRetryOnFailure()
                    );
            }
        }

        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<FollowerModel> Follower { get; set; }
        public DbSet<FriendRequestModel> FriendRequest { get; set; }
        public DbSet<MessageModel> Message { get; set; }
        public DbSet<NotificationModel> Notification { get; set; }

    }

}

