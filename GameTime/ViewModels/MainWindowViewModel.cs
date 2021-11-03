using GameTime.Commands;
using System.Windows.Input;

namespace GameTime.ViewModels
{

    public class MainWindowViewModel : BaseINotify
    {
        #region Commands
  
        public ICommand OpenAddCommand
        {
            get;
            private set;
        }

        public ICommand OpenAddUserCommand
        {
            get;
            private set;
        }

        public ICommand OpenViewCommand
        {
            get;
            private set;
        }

        public ICommand OpenViewUserCommand
        {
            get;
            private set;
        }

        #endregion

        #region MainWindowViewModel Constructor
     
        public MainWindowViewModel()
        {
            this.OpenAddCommand = new OpenAddCommand();
            this.OpenViewCommand = new OpenViewCommand();

            this.OpenAddUserCommand = new OpenAddUserCommand();
            this.OpenViewUserCommand = new OpenViewUserCommand();
        }
        #endregion
    }
}
