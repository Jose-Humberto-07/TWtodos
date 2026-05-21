using Microsoft.EntityFrameworkCore;
using TWtodos.Models;

namespace TWtodos.contexts;

public class TWtodosContextext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
    }
}