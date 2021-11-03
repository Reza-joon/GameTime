using MusicViewer.Models;
using System;
using System.Windows;
using System.Windows.Input;


namespace MusicViewer.Commands
{
    /// <summary>
    /// Removes selected game.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class RemoveGameCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveGameCommand"/> class.
        /// </summary>
        public RemoveGameCommand()
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
        /// Removes SelectedItem game and display a confirmation message. Sets the combobox SelectedItem to the first element of of the combobox to change focus.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (App.Controller.SelectedItem == null)
            {
                MessageBox.Show("Please select an game to delete.", "Simple Music Viewer v1.0", MessageBoxButton.OK);
            }

            else
            {
                MessageBox.Show("The game " + App.Controller.SelectedItem.JeuxNom + " by " + App.Controller.SelectedItem.JeuxDescription +
                    " has been deleted.", "Simple Music Viewer v1.0", MessageBoxButton.OK);

                Game oldSelectedItem = App.Controller.SelectedItem;
                App.Controller.SelectedItem = App.Controller.GamesCollection[0];
                App.Controller.RemoveGame(oldSelectedItem);
            }
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
