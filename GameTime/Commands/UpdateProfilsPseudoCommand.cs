using GameTime.Models;
using System;
using System.Windows.Input;

namespace GameTime.Commands
{

    public class UpdateProfilsPseudoCommand : ICommand, IDisposable
    {

        public event EventHandler UserAdded;
        public event EventHandler CanExecuteChanged;


        public UpdateProfilsPseudoCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }
   
        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.UpdatedProfilsPseudo))
                return false;

            return true;
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            User newUser = new User(App.Controller.UpdatedProfilsPseudo, App.Controller.SelectedUser.ProfilsNom, App.Controller.SelectedUser.ProfilsPrenom, App.Controller.SelectedUser.ProfilsDateNaissance, App.Controller.SelectedUser.ProfilsEmail, App.Controller.SelectedUser.ProfilsMotPasse);
            User oldSelectedUser = App.Controller.SelectedUser;

            App.Controller.AddUser(newUser);
            App.Controller.SelectedUser = newUser;
            App.Controller.RemoveUser(oldSelectedUser);

            if (UserAdded != null)
            {
                UserAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UpdatedProfilsPseudo")
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
