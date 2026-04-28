using Microsoft.EntityFrameworkCore;
using TaskBoardApi.Models;
namespace TaskBoardApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }
    public DbSet<TaskItem> Tasks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TaskItem>().HasData(
            new TaskItem
            {
                Id = 1,
                Title = "изучить asp.net core",
                Description = "контроллеры маршруты middleware",
                IsCompleted = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new TaskItem
            {
                Id = 2,
                Title = "изучить asp.net core",
                Description = "контроллеры маршруты middleware",
                IsCompleted = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new TaskItem
            {
                Id = 3,
                Title = "изучить asp.net core",
                Description = "контроллеры маршруты middleware",
                IsCompleted = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new TaskItem
            {
                Id = 4,
                Title = "изучить asp.net core",
                Description = "контроллеры маршруты middleware",
                IsCompleted = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}