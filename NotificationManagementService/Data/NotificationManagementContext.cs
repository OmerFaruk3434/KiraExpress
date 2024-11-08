using Microsoft.EntityFrameworkCore;
using NotificationManagementService.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NotificationManagementService.Data
{
    public class NotificationManagementContext : DbContext
    {
        public NotificationManagementContext(DbContextOptions<NotificationManagementContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // Kullanıcılar tablosu
        public DbSet<Notification> Notifications { get; set; } // Bildirimler tablosu
        public DbSet<Message> Messages { get; set; } // Mesajlar tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
