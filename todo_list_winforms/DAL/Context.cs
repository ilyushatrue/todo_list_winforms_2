using Microsoft.EntityFrameworkCore;
using todo_list_winforms.DAL.Models;

namespace todo_list_winforms.DAL;

public class Context : DbContext
{
    public DbSet<TodoNote> TodoNotes { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\99ily\\Documents\\ASP.NET\\test\\todo_list_winforms\\db\\TodoDb.db");
    }
}
