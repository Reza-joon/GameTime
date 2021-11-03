using MusicViewer.Commands;
using MusicViewer.ViewModels;
using MusicViewer.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MusicViewer.ViewModels
{

    public class UpdateOrDeleteUserViewModel : BaseINotify, IDisposable
    {

        #region Commands
        public ICommand RemoveUserCommand
        {
            get;
            private set;
        }


        public UpdateProfilsPseudoCommand UpdateProfilsPseudoCommand
        {
            get;
            private set;
        }

        public UpdateProfilsNomCommand UpdateProfilsNomCommand
        {
            get;
            private set;
        }

        public UpdateProfilsPrenomCommand UpdateProfilsPrenomCommand
        {
            get;
            private set;
        }

        public UpdateProfilsDateNaissanceCommand UpdateProfilsDateNaissanceCommand
        {
            get;
            private set;
        }


        public UpdateProfilsEmailCommand UpdateProfilsEmailCommand
        {
            get;
            private set;
        }

        public UpdateProfilsMotPasseCommand UpdateProfilsMotPasseCommand
        {
            get;
            private set;
        }
        #endregion


        public ReadOnlyObservableCollection<User> NewUsersCollection
        {
            get
            {
                return App.Controller.UsersCollection;
            }
        }

        #region NewUser Properties
        public string NewProfilsPseudo
        {
            get
            {
                return App.Controller.NewProfilsPseudo;
            }

            set
            {
                App.Controller.NewProfilsPseudo = value;
                //this.NotifyPropertyChanged("NewProfilsPseudo");
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
                //this.NotifyPropertyChanged("NewProfilsNom");
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
                //this.NotifyPropertyChanged("NewProfilsPrenom");
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
                //this.NotifyPropertyChanged("NewProfilsDateNaissance");
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
                //this.NotifyPropertyChanged("NewProfilsEmail");
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
                //this.NotifyPropertyChanged("NewProfilsMotPasse");
            }
        }




        public User SelectedUser
        { 
            get
            {
                return App.Controller.SelectedUser;
            }
            set
            {
                App.Controller.SelectedUser = value;
                //this.NotifyPropertyChanged("SelectedItem");
            }
        }

        public string UpdatedProfilsPseudo
        {
            get
            {
                return App.Controller.UpdatedProfilsPseudo;
            }
            set
            {
                App.Controller.UpdatedProfilsPseudo = value;
                //this.NotifyPropertyChanged("UpdatedProfilsPseudo");
            }
        }

        public string UpdatedProfilsNom
{
            get
            {
                return App.Controller.UpdatedProfilsNom;
            }
            set
            {
                App.Controller.UpdatedProfilsNom = value;
                //this.NotifyPropertyChanged("UpdatedProfilsNom");
            }
        }

        public string UpdatedProfilsPrenom
{
            get
            {
                return App.Controller.UpdatedProfilsPrenom;
            }
            set
            {
                App.Controller.UpdatedProfilsPrenom = value;
                //this.NotifyPropertyChanged("UpdatedProfilsPrenom");
            }
        }

        public string UpdatedProfilsDateNaissance
{
            get
            {
                return App.Controller.UpdatedProfilsDateNaissance;
            }
            set
            {
                App.Controller.UpdatedProfilsDateNaissance = value;
                //this.NotifyPropertyChanged("UpdatedProfilsDateNaissance");
            }
        }

        public string UpdatedProfilsEmail
{
            get
            {
                return App.Controller.UpdatedProfilsEmail;
            }
            set
            {
                App.Controller.UpdatedProfilsEmail = value;
                //this.NotifyPropertyChanged("UpdatedProfilsEmail");
            }
        }

        public string UpdatedProfilsMotPasse
{
            get
            {
                return App.Controller.UpdatedProfilsMotPasse;
            }
            set
            {
                App.Controller.UpdatedProfilsMotPasse = value;
                //this.NotifyPropertyChanged("UpdatedProfilsMotPasse");
            }
        }
        #endregion

        #region UpdateOrDeleteUserViewModel Constructor
        public UpdateOrDeleteUserViewModel()
        {
            this.RemoveUserCommand = new RemoveUserCommand();
            this.UpdateProfilsPseudoCommand = new UpdateProfilsPseudoCommand();
            this.UpdateProfilsNomCommand = new UpdateProfilsNomCommand();
            this.UpdateProfilsPrenomCommand = new UpdateProfilsPrenomCommand();
            this.UpdateProfilsDateNaissanceCommand = new UpdateProfilsDateNaissanceCommand();
            this.UpdateProfilsEmailCommand = new UpdateProfilsEmailCommand();
            this.UpdateProfilsMotPasseCommand = new UpdateProfilsMotPasseCommand();


            App.Controller.PropertyChanged += onControllerPropertyChanged;
            UpdateProfilsPseudoCommand.UserAdded += onUpdateProfilsPseudoCommandUserAdded;
            UpdateProfilsNomCommand.UserAdded += onUpdateProfilsNomCommandUserAdded;
            UpdateProfilsPrenomCommand.UserAdded += onUpdateProfilsPrenomCommandUserAdded;
            UpdateProfilsDateNaissanceCommand.UserAdded += onUpdateProfilsDateNaissanceCommandUserAdded;
            UpdateProfilsEmailCommand.UserAdded += onUpdateProfilsEmailCommandUserAdded;
            UpdateProfilsMotPasseCommand.UserAdded += onUpdateProfilsMotPasseCommandUserAdded;
        }
        #endregion

        #region PropertyChanged Methods
        void onControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.NotifyPropertyChanged(e.PropertyName);
        }

        void onUpdateProfilsPseudoCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsPseudo = string.Empty;
        }

        void onUpdateProfilsNomCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsNom = string.Empty;
        }

        void onUpdateProfilsPrenomCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsPrenom = string.Empty;
        }

        void onUpdateProfilsDateNaissanceCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsDateNaissance = string.Empty;
        }

        void onUpdateProfilsEmailCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsEmail = string.Empty;
        }

        void onUpdateProfilsMotPasseCommandUserAdded(object sender, EventArgs e)
        {
            UpdatedProfilsMotPasse = string.Empty;
        }
        #endregion

        public void Dispose()
        {
            if (UpdateProfilsPseudoCommand != null)
            {
                UpdateProfilsPseudoCommand.Dispose();
                UpdateProfilsPseudoCommand = null;
            }

            if (UpdateProfilsNomCommand != null)
            {
                UpdateProfilsNomCommand.Dispose();
                UpdateProfilsNomCommand = null;
            }


            if (UpdateProfilsPrenomCommand != null)
            {
                UpdateProfilsPrenomCommand.Dispose();
                UpdateProfilsPrenomCommand = null;
            }

            if (UpdateProfilsDateNaissanceCommand != null)
            {
                UpdateProfilsDateNaissanceCommand.Dispose();
                UpdateProfilsDateNaissanceCommand = null;
            }

            if (UpdateProfilsEmailCommand != null)
            {
                UpdateProfilsEmailCommand.Dispose();
                UpdateProfilsEmailCommand = null;
            }

            if (UpdateProfilsMotPasseCommand != null)
            {
                UpdateProfilsMotPasseCommand.Dispose();
                UpdateProfilsMotPasseCommand = null;
            }

        }
    }

}
