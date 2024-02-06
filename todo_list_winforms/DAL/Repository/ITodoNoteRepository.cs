using todo_list_winforms.DAL.Models;

namespace todo_list_winforms.DAL.Repository;

public interface ITodoNoteRepository
{
    void Create(TodoNote note);
    void Update(TodoNote note);
    void Delete(int id);
    IEnumerable<TodoNote> GetAll(bool completedOnly);
}
