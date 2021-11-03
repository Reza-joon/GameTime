using MusicViewer.Models;
using System;
using System.Windows.Input;

namespace MusicViewer.Commands
{

    public class AddNewUserCommand : ICommand
    {
        public event EventHandler UserAdded;
        public event EventHandler CanExecuteChanged;


        public AddNewUserCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }


        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.NewProfilsPseudo) || String.IsNullOrEmpty(App.Controller.NewProfilsNom))
                return false;

            return true;
        }

         public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            User newUser = new User(App.Controller.NewProfilsPseudo, App.Controller.NewProfilsNom, App.Controller.NewProfilsPrenom, App.Controller.NewProfilsDateNaissance, App.Controller.NewProfilsEmail, App.Controller.NewProfilsMotPasse);

            App.Controller.AddUser(newUser);

            if (UserAdded != null)
            {
                UserAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "NewProfilsPseudo" || e.PropertyName == "NewProfilsNom")
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
