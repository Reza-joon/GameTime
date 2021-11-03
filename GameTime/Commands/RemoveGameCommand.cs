using GameTime.Models;
using System;
using System.Windows;
using System.Windows.Input;


namespace GameTime.Commands
{

    public class RemoveGameCommand : ICommand
    {
     
        public RemoveGameCommand()
        {

        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

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


        public event EventHandler CanExecuteChanged;

    }
}
