using todo_list_winforms.DAL;
using todo_list_winforms.DAL.Repository;
using todo_list_winforms.Presenters;

namespace todo_list_winforms
{
    internal static class Program
    {
        public static Context Context { get; private set; } = null!;
        [STAThread]
        static void Main()
        {
            Context = new Context();
            ApplicationConfiguration.Initialize();

            var view = new TodoNoteView();
            var repository = new TodoNoteRepository(Context);
            _ = new TodoNotePresenter(view, repository);
            Application.Run(view);
        }
    }
}