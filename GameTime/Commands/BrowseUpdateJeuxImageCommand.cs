using Microsoft.Win32;
using MusicViewer.Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace MusicViewer.Commands
{
    /// <summary>
    /// Browse for a new file when updating the game cover path
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class BrowseUpdateJeuxImageCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseUpdateJeuxImageCommand"/> class.
        /// </summary>
        public BrowseUpdateJeuxImageCommand()
        {

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
            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// New game (newGame) is created that contains existing game name, existing artist name, and the newly set game cover path. newGame is added
        /// to the ObservableCollection and old game SelectedItem is removed. ComboBox SelectedItem is then set to newGame to change focus.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (App.Controller.SelectedItem == null)
            {
                MessageBox.Show("Please select an game to update", "Simple Music Viewer v1.0", MessageBoxButton.OK);
            }

            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (openFileDialog.ShowDialog() == true)
                {
                    App.Controller.SelectedItem.JeuxImage = openFileDialog.FileName;
                }

                if (GameAdded != null)
                {
                    GameAdded(this, EventArgs.Empty);
                }

                Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.SelectedItem.JeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.SelectedItem.JeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);
                Game oldSelectedItem = App.Controller.SelectedItem;

                App.Controller.AddGame(newGame);
                App.Controller.SelectedItem = newGame;
                App.Controller.RemoveGame(oldSelectedItem);
            }
        }

        public event EventHandler GameAdded;

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
