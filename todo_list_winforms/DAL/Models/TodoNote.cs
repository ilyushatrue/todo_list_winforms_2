using todo_list_winforms.DAL.Interfaces;
using todo_list_winforms.DAL.Models.Base;

namespace todo_list_winforms.DAL.Models;

public class TodoNote : BaseEntity, ITodoNote
{
    public bool IsDone { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
