using Microsoft.EntityFrameworkCore;
using todo_list_winforms.DAL.Models;

namespace todo_list_winforms.DAL.Repository;

public class TodoNoteRepository : ITodoNoteRepository
{
    private readonly Context _context;
    public TodoNoteRepository(Context context) 
    {
        _context = context;
    }

    public void Create(TodoNote note)
    {
        _context.Set<TodoNote>();
        _context.Attach(note);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void Delete(int id)
    {
        _context.Set<TodoNote>();
        _context.Remove(new TodoNote { Id = id });  
        _context.SaveChanges();
    }

    public void Update(TodoNote note)
    {
        _context.Entry(note).State = EntityState.Modified;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public IEnumerable<TodoNote> GetAll(bool completedOnly)
    {
        var query = _context.Set<TodoNote>().AsNoTracking();
        if (completedOnly == true) query = query.Where(x => x.IsDone == false);
        return query.ToArray();
    }
}
