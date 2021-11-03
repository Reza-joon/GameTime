using MusicViewer.Models;
using System;
using System.Windows.Input;

namespace MusicViewer.Commands
{
    /// <summary>
    /// Add a new game from user-given data.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class AddNewGameCommand : ICommand
    {
        public event EventHandler GameAdded;
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewGameCommand"/> class.
        /// </summary>
        public AddNewGameCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.NewJeuxNom) || String.IsNullOrEmpty(App.Controller.NewJeuxDescription))
                return false;

            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// New game (newGame) is created that contains user-given game name, user-given artist name, and user-given game cover. newGame is then added
        /// to the ObservableCollection. If newGame is null or if artist name or game name are missing, an error is shown.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            Game newGame = new Game(App.Controller.NewJeuxNom, App.Controller.NewJeuxDescription, App.Controller.NewJeuxImage, App.Controller.NewJeuxDate, App.Controller.NewJeuxGenre, App.Controller.NewJeuxPEGI, App.Controller.NewJeuxPlatforme, App.Controller.NewJeuxVersion);

            App.Controller.AddGame(newGame);

            if (GameAdded != null)
            {
                GameAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "NewJeuxDescription" || e.PropertyName == "NewJeuxNom")
            {
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        public void Dispose()
        {
            App.Controller.PropertyChanged -= onControllerPropertyChanged;
        }
    }
}
