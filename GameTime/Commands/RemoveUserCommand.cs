using GameTime.Models;
using System;
using System.Windows;
using System.Windows.Input;


namespace GameTime.Commands
{

    public class RemoveUserCommand : ICommand
    {

        public RemoveUserCommand()
        {

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (App.Controller.SelectedUser == null)
            {
                MessageBox.Show("Please select an user to delete.", "Simple Music Viewer v1.0", MessageBoxButton.OK);
            }

            else
            {
                MessageBox.Show("The user " + App.Controller.SelectedUser.ProfilsPseudo + " by " + App.Controller.SelectedUser.ProfilsNom +
                    " has been deleted.", "Simple Music Viewer v1.0", MessageBoxButton.OK);

                User oldSelectedUser = App.Controller.SelectedUser;
                App.Controller.SelectedUser = App.Controller.UsersCollection[0];
                App.Controller.RemoveUser(oldSelectedUser);
            }
        }

        public event EventHandler CanExecuteChanged;

    }
}
