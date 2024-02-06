using todo_list_winforms.Views;

namespace todo_list_winforms;

public partial class TodoNoteView : Form, ITodoNoteView
{
    public TodoNoteView()
    {
        InitializeComponent();
        deadline_dateTimePicker.Format = DateTimePickerFormat.Custom;
        deadline_dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm";
        startDate_dateTimePicker.Format = DateTimePickerFormat.Custom;
        startDate_dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm";
        save_button.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
        delete_button.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
        create_button.Click += delegate { CreateEvent?.Invoke(this, EventArgs.Empty); };
        todo_dataGrid.CellClick += delegate { TodoListClickEvent?.Invoke(this, EventArgs.Empty); };
        isCompleted_checkBox.Click += delegate { OnlyCompletedEvent?.Invoke(this, EventArgs.Empty); };
    }

    public int Id
    {
        get
        {
            var idColumnIndex = 0;
            if (todo_dataGrid.Rows.Count > 0)
            {
                var selectedRow = todo_dataGrid.Rows[todo_dataGrid.CurrentCell.RowIndex];
                return (int)selectedRow.Cells[idColumnIndex].Value;
            }
            else { return 0; }
        }
        set { }
    }

    public bool IsDone { get => isDone_checkBox.Checked; set => isDone_checkBox.Checked = value; }
    public string Title { get => title_textBox.Text; set => title_textBox.Text = value; }
    public string? Description { get => description_textBox.Text; set => description_textBox.Text = value; }
    public DateTime? StartDate
    {
        get
        {
            var isDateParsed = DateTime.TryParse(startDate_dateTimePicker.Text, out DateTime date);
            if (isDateParsed) return date;
            else return null;
        }
        set { }
    }
    public DateTime? EndDate
    {
        get
        {
            var isDateParsed = DateTime.TryParse(deadline_dateTimePicker.Text, out DateTime date);
            if (isDateParsed) return date;
            else return null;
        }
        set => deadline_dateTimePicker.Text = value.ToString();
    }
    public bool IsSuccessful { get; set; }
    public string? Message { get; set; }
    public bool ShowOnlyCompleted { get => isCompleted_checkBox.Checked; set => isCompleted_checkBox.Checked = value; }

    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler CreateEvent;
    public event EventHandler CancelEvent;
    public event EventHandler TodoListClickEvent;
    public event EventHandler UpdateEvent;
    public event EventHandler OnlyCompletedEvent;

    public void SetTodoListBindingSource(BindingSource todoList)
    {
        todo_dataGrid.DataSource = todoList;
    }

    public void ShowMessage(string message)
    {
        MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}
