using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private bool _isAddBook;
        public List<BBK> BBKs { get; private set; }
        public List<Author> Authors { get; private set; }
        public List<Publisher> Publishers { get; private set; }
        public AddEditBookViewModel(Publication pub = null)
        {
            if(pub == null)
            {
                Publication = new Publication();
                _isAddBook = true;
                Title = "Добавить";

            }
            else
            {
                Publication = pub;
                Title = "Редактировать";
            }

            BBKs = DataBase.GetEntities().BBK.ToList();
            Authors = DataBase.GetEntities().Author.ToList();
            Publishers = DataBase.GetEntities().Publisher.ToList();
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
