namespace todo_list_winforms.Views;

public interface ITodoNoteView
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsSuccessful { get; set; }
    public string? Message { get; set; }
    public bool ShowOnlyCompleted { get; set; }

    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler UpdateEvent;
    event EventHandler CreateEvent;
    event EventHandler CancelEvent;
    event EventHandler TodoListClickEvent;
    event EventHandler OnlyCompletedEvent;

    void SetTodoListBindingSource(BindingSource todoList);
    void Show();
    void ShowMessage(string message);
}
