using MusicViewer.ViewModels;
using MusicViewer.Models;
using System;
using System.Windows.Input;

namespace MusicViewer.Commands
{
    /// <summary>
    /// Clears the selected game art.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class ClearUpdateJeuxImageCommand : ICommand, IDisposable
    {
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearUpdateJeuxImageCommand"/> class.
        /// </summary>
        public ClearUpdateJeuxImageCommand()
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
            if (App.Controller.SelectedItem.JeuxImage == MainViewModel.defaultJeuxImage)
                return false;

            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// New game (newGame) is created that contains existing game name, existing artist name, and the newly cleared (nulled) game cover path. newGame
        /// is added to the ObservableCollection and old game SelectedItem is removed. ComboBox SelectedItem is then set to newGame to change focus.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            App.Controller.SelectedItem.JeuxImage = MainViewModel.defaultJeuxImage;

            Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.SelectedItem.JeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.SelectedItem.JeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);

            Game oldSelectedItem = App.Controller.SelectedItem;

            App.Controller.AddGame(newGame);
            App.Controller.SelectedItem = newGame;
            App.Controller.RemoveGame(oldSelectedItem);
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedItem")
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
