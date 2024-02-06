namespace todo_list_winforms.DAL.Interfaces;

public interface ITodoNote
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
