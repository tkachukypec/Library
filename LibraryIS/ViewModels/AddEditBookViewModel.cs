using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryIS.ViewModels
{
    class AddEditBookViewModel : ViewModelBase
    {
        private Publication _publication;
        public Publication Publication
        {
            get => _publication;
            set
            {
                if(_publication != value)
                {
                    _publication = value;
                    PropertyChange();
                }
            }
        }
        private Book _book;
        public Book Book
        {
            get => _book;
            set
            {
                if (_book != value)
                {
                    _book = value;
                    PropertyChange();
                }
            }
        }

        private bool _isAddBook;
        public List<YDK> YDKs { get; private set; }
        public List<BBK> BBKs { get; private set; }
        public List<Author> Authors { get; private set; }
        public List<Publisher> Publishers { get; private set; }
        public List<Book> Books { get; private set; }
        public AddEditBookViewModel(Publication pub = null)
        {
            if(pub == null)
            {

                Publication = new Publication();
                Publication.YDK = DataBase.GetEntities().YDK.FirstOrDefault();
                Publication.Pages = 100;
                Publication.ISBN = "WEWASEGGW";
                Publication.Record = "qq";
                Publication.Article = "123";
                Publication.Count = 100;
                Publication.Left = 50;
                _isAddBook = true;
                Title = "Добавить";

            }
            else
            {
                Publication = pub;
                Title = "Редактировать";
            }

            BBKs = DataBase.GetEntities().BBK.ToList();
            YDKs = DataBase.GetEntities().YDK.ToList();
            Authors = DataBase.GetEntities().Author.ToList();
            Publishers = DataBase.GetEntities().Publisher.ToList();
            Books = DataBase.GetEntities().Book.ToList();
        }
        private Command _saveCommand;
        public Command SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new Command(
                    obj =>
                    {
                        if (_isAddBook)
                        {
                            DataBase.GetEntities().Publication.Add(Publication);
                            _isAddBook = false;
                        }
                        try
                        {
                            DataBase.SaveChanges();
                            OnCommandExecuted(CommandExecutedResult.Ok);
                        }
                        catch (Exception ex)
                        {
                            OnCommandExecuted(CommandExecutedResult.Error, ex.Message);

                        }
                    }));
            }
        }
    }
}
