using MusicViewer.Commands;
using MusicViewer.ViewModels;
using MusicViewer.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MusicViewer.ViewModels
{

    public class AddUserViewModel : BaseINotify, IDisposable
    {
        // Commands
        public AddNewUserCommand AddNewUserCommand
        {
            get;
            private set;
        }

        public ReadOnlyObservableCollection<User> NewUsersCollection
        {
            get
            {
                return App.Controller.UsersCollection;
            }
        }

        // NewUser Properties
        public string NewProfilsPseudo
        {
            get
            {
                return App.Controller.NewProfilsPseudo;
            }

            set
            {
                App.Controller.NewProfilsPseudo = value;
            }
        }

        public string NewProfilsNom
        {
            get
            {
                return App.Controller.NewProfilsNom;
            }
            set
            {
                App.Controller.NewProfilsNom = value;
            }
        }

        public string NewProfilsPrenom
        {
            get
            {
                return App.Controller.NewProfilsPrenom;
            }
            set
            {
                App.Controller.NewProfilsPrenom = value;
            }
        }

        public string NewProfilsDateNaissance
        {
            get
            {
                return App.Controller.NewProfilsDateNaissance;
            }
            set
            {
                App.Controller.NewProfilsDateNaissance = value;
            }
        }

        public string NewProfilsEmail
        {
            get
            {
                return App.Controller.NewProfilsEmail;
            }
            set
            {
                App.Controller.NewProfilsEmail = value;
            }
        }

        public string NewProfilsMotPasse
        {
            get
            {
                return App.Controller.NewProfilsMotPasse;
            }
            set
            {
                App.Controller.NewProfilsMotPasse = value;
            }
        }



        // AddUserViewModel Constructor

        public AddUserViewModel()
        {
            this.AddNewUserCommand = new AddNewUserCommand();

            App.Controller.PropertyChanged += onControllerPropertyChanged;
            AddNewUserCommand.UserAdded += onAddNewUserCommandUserAdded;
        }

        // PropertyChanged Methods
        void onControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.NotifyPropertyChanged(e.PropertyName);
        }

        void onAddNewUserCommandUserAdded(object sender, EventArgs e)
        {
            NewProfilsPseudo = string.Empty;
            NewProfilsNom = string.Empty;
            NewProfilsPrenom = string.Empty;
            NewProfilsDateNaissance = string.Empty;
            NewProfilsEmail = string.Empty;
            NewProfilsMotPasse = string.Empty;
  
        }
  
        public void Dispose()
        {
            if (AddNewUserCommand != null)
            {
                AddNewUserCommand.Dispose();
                AddNewUserCommand = null;
            }
        }
    }
}
