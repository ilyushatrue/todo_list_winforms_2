using System.Timers;
using todo_list_winforms.DAL.Models;
using todo_list_winforms.DAL.Repository;
using todo_list_winforms.Views;
using Timer = System.Timers.Timer;

namespace todo_list_winforms.Presenters;

public class TodoNotePresenter
{
    private ITodoNoteView _view;
    private ITodoNoteRepository _repository;
    private BindingSource _bindingSource;
    private IEnumerable<TodoNote> _todoList;

    public TodoNotePresenter(ITodoNoteView view, ITodoNoteRepository repository)
    {
        _view = view;
        _repository = repository;
        _bindingSource = new();
        _view.EditEvent += SelectTodo;
        _view.DeleteEvent += DeleteSelectedTodo;
        _view.CreateEvent += CreateTodo;
        _view.UpdateEvent += UpdateTodo;
        _view.CancelEvent += CancelAction;
        _view.OnlyCompletedEvent += LoadNotCompletedTodoList;
        _view.TodoListClickEvent += SelectTodo;
        _view.SetTodoListBindingSource(_bindingSource);
        LoadAllTodoList();
        _view.Show();
    }

    private void LoadNotCompletedTodoList(object? sender, EventArgs e) => LoadAllTodoList(_view.ShowOnlyCompleted);
    private void LoadAllTodoList(bool notCompletedOnly = false)
    {
        _todoList = _repository.GetAll(notCompletedOnly);

        foreach (var todo in _todoList)
        {
            if (todo.EndDate == null) continue;
            TimeSpan timeUntilEvent = todo.EndDate.Value.Subtract(DateTime.Now).Subtract(TimeSpan.FromMinutes(5));
            if (timeUntilEvent.TotalMilliseconds <= 0 || timeUntilEvent.TotalMilliseconds >= double.MaxValue || (int)timeUntilEvent.TotalMilliseconds<0) continue;
            var timer = new Timer(timeUntilEvent.TotalMilliseconds);
            timer.Elapsed += NotifySoonExpires;
            timer.AutoReset = false;
            timer.Start();
        }

        _bindingSource.DataSource = _todoList;
    }

    private void CancelAction(object? sender, EventArgs e)
    {
        CleanViewFields();
    }

    private void UpdateTodo(object? sender, EventArgs e)
    {
        var model = MapViewToModel();
        if (model == null || model.Id == 0) { return; }
        try
        {
            _repository.Update(model);
            _view.Message = "Задача обновлена";
            _view.IsSuccessful = true;
            LoadAllTodoList();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = ex.Message;
            throw;
        }
    }

    private void CreateTodo(object? sender, EventArgs e)
    {
        var model = MapViewToModel();
        model.Id = 0;

        try
        {
            _repository.Create(model);
            _view.Message = "Задача создана";
            _view.IsSuccessful = true;
            LoadAllTodoList();
            CleanViewFields();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = ex.Message;
            throw;
        }
    }

    private void NotifySoonExpires(object sender, ElapsedEventArgs e)
    {
        _view.ShowMessage($"Через 5 минут истечет крайний срок задачи '{_view.Title}");
    }

    private void CleanViewFields()
    {
        _view.Id = 0;
        _view.Title = "";
        _view.Description = "";
        _view.StartDate = null;
        _view.EndDate = null;
        _view.IsDone = false;
    }

    private void DeleteSelectedTodo(object? sender, EventArgs e)
    {
        try
        {
            var todo = (TodoNote)_bindingSource.Current;
            if(todo==null || todo.Id == 0) { return; }
            _repository.Delete(todo.Id);
            _view.IsSuccessful = true;
            _view.Message = "Задача удалена";
            CleanViewFields();
            LoadAllTodoList();
        }
        catch (Exception ex)
        {
            _view.IsSuccessful = false;
            _view.Message = ex.Message;
            throw;
        }
    }

    private void SelectTodo(object? sender, EventArgs e)
    {
        var todo = (TodoNote)_bindingSource.Current;
        _view.Id = todo.Id;
        _view.Title = todo.Title;
        _view.Description = todo.Description;
        _view.StartDate = todo.StartDate;
        _view.EndDate = todo.EndDate;
        _view.IsDone = todo.IsDone;
    }

    private TodoNote MapViewToModel()
    {
        return new TodoNote
        {
            Id = _view.Id,
            Title = _view.Title,
            Description = _view.Description,
            IsDone = _view.IsDone,
            StartDate = _view.StartDate,
            EndDate = _view.EndDate
        };
    }
}
