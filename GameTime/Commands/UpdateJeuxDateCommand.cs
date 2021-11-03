using MusicViewer.Models;
using System;
using System.Windows.Input;

namespace MusicViewer.Commands
{
    /// <summary>
    /// Updates the ArtistName property of an game.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class UpdateJeuxDateCommand : ICommand, IDisposable
    {

        public event EventHandler GameAdded;
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJeuxDateCommand"/> class.
        /// </summary>
        public UpdateJeuxDateCommand()
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
            if (String.IsNullOrEmpty(App.Controller.UpdatedJeuxDate))
                return false;

            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// New game (newGame) is created that contains existing game name, user-given artist name, and existing game cover. newGame is added to the
        /// ObservableCollection and SelectedItem game is removed. Combobox SelectedItem is set to newGame to change focus.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            // Code below not necessary?
            //if (CanExecute(parameter) == false)
            //    return;

            Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.SelectedItem.JeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.UpdatedJeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);
            Game oldSelectedItem = App.Controller.SelectedItem;

            App.Controller.AddGame(newGame);
            App.Controller.SelectedItem = newGame;
            App.Controller.RemoveGame(oldSelectedItem);

            if (GameAdded != null)
            {
                GameAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UpdatedJeuxDate")
            {
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            App.Controller.PropertyChanged -= onControllerPropertyChanged;
        }
    }
}
