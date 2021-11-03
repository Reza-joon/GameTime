using GameTime.Models;
using System.Collections.ObjectModel;

namespace GameTime.ViewModels
{

    public class MainViewModel : BaseINotify
    {
        public const string defaultJeuxImage = "/GameTime;component/Images/default.jpg";

        private GameLibrary gameLibrary;
        private UserLibrary userLibrary;
        public ReadOnlyObservableCollection<Game> GamesCollection;
        public ReadOnlyObservableCollection<User> UsersCollection;

       
        public MainViewModel(GameLibrary gameLibrary, UserLibrary userLibrary)
        {
            this.gameLibrary = gameLibrary;
            this.userLibrary = userLibrary;
            this.GamesCollection = new ReadOnlyObservableCollection<Game>(gameLibrary.GamesCollection);
            this.UsersCollection = new ReadOnlyObservableCollection<User>(userLibrary.UsersCollection);
            if (this.GamesCollection.Count > 0)
                selectedItem = GamesCollection[0];
            if (this.UsersCollection.Count > 0)
                selectedUser = UsersCollection[0];
        }

        #region Game Variables
        private string newJeuxNom;
        private string newJeuxDescription;
        private string newJeuxImage;
        private string newJeuxDate;
        private string newJeuxGenre;
        private string newJeuxPEGI;
        private string newJeuxPlatforme;
        private string newJeuxVersion;

        private string updatedJeuxNom;
        private string updatedJeuxDescription;
        private string updatedJeuxDate;
        private string updatedJeuxGenre;
        private string updatedJeuxPEGI;
        private string updatedJeuxPlatforme;
        private string updatedJeuxVersion;

        private Game selectedItem;

        #endregion

        // User Variables
        private string newProfilsPseudo;
        private string newProfilsNom;
        private string newProfilsPrenom;
        private string newProfilsDateNaissance;
        private string newProfilsEmail;
        private string newProfilsMotPasse;

        private string updatedProfilsPseudo;
        private string updatedProfilsNom;
        private string updatedProfilsPrenom;
        private string updatedProfilsDateNaissance;
        private string updatedProfilsEmail;
        private string updatedProfilsMotPasse;

        private User selectedUser;




        #region CRUD Methods

        public void AddGame(Game gameToAdd)
        {
            this.gameLibrary.GamesCollection.Add(gameToAdd);
        }

        public void AddUser(User userToAdd)
        {
            this.userLibrary.UsersCollection.Add(userToAdd);
        }

        public void RemoveGame(Game gameToRemove)
        {
            this.gameLibrary.GamesCollection.Remove(gameToRemove);
        }

        public void RemoveUser(User userToRemove)
        {
            this.userLibrary.UsersCollection.Remove(userToRemove);
        }
        #endregion

        // Game Properties
 
        public string NewJeuxNom
        {
            get
            {
                return newJeuxNom;
            }
            set
            {
                newJeuxNom = value;
                this.NotifyPropertyChanged("NewJeuxNom");
            }
        }

        public string NewJeuxDescription
        {
            get
            {
                return newJeuxDescription;
            }
            set
            {
                newJeuxDescription = value;
                this.NotifyPropertyChanged("NewJeuxDescription");
            }
        }

        public string NewJeuxImage
        {
            get
            {
                return newJeuxImage;
            }
            set
            {
                newJeuxImage = value;
                this.NotifyPropertyChanged("NewJeuxImage");
            }
        }

        public string NewJeuxDate
        {
            get
            {
                return newJeuxDate;
            }
            set
            {
                newJeuxDate = value;
                this.NotifyPropertyChanged("NewJeuxDate");
            }
        }

        public string NewJeuxGenre
        {
            get
            {
                return newJeuxGenre;
            }
            set
            {
                newJeuxGenre = value;
                this.NotifyPropertyChanged("NewJeuxGenre");
            }
        }

        public string NewJeuxPEGI
        {
            get
            {
                return newJeuxPEGI;
            }
            set
            {
                newJeuxPEGI = value;
                this.NotifyPropertyChanged("NewJeuxPEGI");
            }
        }

        public string NewJeuxPlatforme
        {
            get
            {
                return newJeuxPlatforme;
            }
            set
            {
                newJeuxPlatforme = value;
                this.NotifyPropertyChanged("NewJeuxPlatforme");
            }
        }

        public string NewJeuxVersion
        {
            get
            {
                return newJeuxVersion;
            }
            set
            {
                newJeuxVersion = value;
                this.NotifyPropertyChanged("NewJeuxVersion");
            }
        }


        public string UpdatedJeuxNom
        {
            get
            {
                return updatedJeuxNom;
            }
            set
            {
                updatedJeuxNom = value;
                this.NotifyPropertyChanged("UpdatedJeuxNom");
            }
        }

        public string UpdatedJeuxDescription
        {
            get
            {
                return updatedJeuxDescription;
            }
            set
            {
                updatedJeuxDescription = value;
                this.NotifyPropertyChanged("UpdatedJeuxDescription");
            }
        }

        public string UpdatedJeuxDate
        {
            get
            {
                return updatedJeuxDate;
            }
            set
            {
                updatedJeuxDate = value;
                this.NotifyPropertyChanged("UpdatedJeuxDate");
            }
        }

        public string UpdatedJeuxGenre
        {
            get
            {
                return updatedJeuxGenre;
            }
            set
            {
                updatedJeuxGenre = value;
                this.NotifyPropertyChanged("UpdatedJeuxGenre");
            }
        }

        public string UpdatedJeuxPEGI
        {
            get
            {
                return updatedJeuxPEGI;
            }
            set
            {
                updatedJeuxPEGI = value;
                this.NotifyPropertyChanged("UpdatedJeuxPEGI");
            }
        }

        public string UpdatedJeuxPlatforme
        {
            get
            {
                return updatedJeuxPlatforme;
            }
            set
            {
                updatedJeuxPlatforme = value;
                this.NotifyPropertyChanged("UpdatedJeuxPlatforme");
            }
        }

        public string UpdatedJeuxVersion
        {
            get
            {
                return updatedJeuxVersion;
            }
            set
            {
                updatedJeuxVersion = value;
                this.NotifyPropertyChanged("UpdatedJeuxVersion");
            }
        }



        // user Properties
        public string NewProfilsPseudo
        {
            get
            {
                return newProfilsPseudo;
            }
            set
            {
                newProfilsPseudo = value;
                this.NotifyPropertyChanged("NewProfilsPseudo");
            }
        }

        public string NewProfilsNom
        {
            get
            {
                return newProfilsNom;
            }
            set
            {
                newProfilsNom = value;
                this.NotifyPropertyChanged("NewProfilsNom");
            }
        }

        public string NewProfilsPrenom
        {
            get
            {
                return newProfilsPrenom;
            }
            set
            {
                newProfilsPrenom = value;
                this.NotifyPropertyChanged("NewProfilsPrenom");
            }
        }

        public string NewProfilsDateNaissance
        {
            get
            {
                return newProfilsDateNaissance;
            }
            set
            {
                newProfilsDateNaissance = value;
                this.NotifyPropertyChanged("NewProfilsDateNaissance");
            }
        }

        public string NewProfilsEmail
        {
            get
            {
                return newProfilsEmail;
            }
            set
            {
                newProfilsEmail = value;
                this.NotifyPropertyChanged("NewProfilsEmail");
            }
        }

        public string NewProfilsMotPasse
        {
            get
            {
                return newProfilsMotPasse;
            }
            set
            {
                newProfilsMotPasse = value;
                this.NotifyPropertyChanged("NewProfilsMotPasse");
            }
        }


        public string UpdatedProfilsPseudo
        {
            get
            {
                return updatedProfilsPseudo;
            }
            set
            {
                updatedProfilsPseudo = value;
                this.NotifyPropertyChanged("UpdatedProfilsPseudo");
            }
        }

        public string UpdatedProfilsNom
        {
            get
            {
                return updatedProfilsNom;
            }
            set
            {
                updatedProfilsNom = value;
                this.NotifyPropertyChanged("UpdatedProfilsNom");
            }
        }

        public string UpdatedProfilsPrenom
        {
            get
            {
                return updatedProfilsPrenom;
            }
            set
            {
                updatedProfilsPrenom = value;
                this.NotifyPropertyChanged("UpdatedProfilsPrenom");
            }
        }

        public string UpdatedProfilsDateNaissance
        {
            get
            {
                return updatedProfilsDateNaissance;
            }
            set
            {
                updatedProfilsDateNaissance = value;
                this.NotifyPropertyChanged("UpdatedProfilsDateNaissance");
            }
        }

        public string UpdatedProfilsEmail
        {
            get
            {
                return updatedProfilsEmail;
            }
            set
            {
                updatedProfilsEmail = value;
                this.NotifyPropertyChanged("UpdatedProfilsEmail");
            }
        }

        public string UpdatedProfilsMotPasse
        {
            get
            {
                return updatedProfilsMotPasse;
            }
            set
            {
                updatedProfilsMotPasse = value;
                this.NotifyPropertyChanged("UpdatedProfilsMotPasse");
            }
        }


        // SelectedItem 
        public Game SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                this.NotifyPropertyChanged("SelectedItem");
            }
        }

        // SelectedUser
        public User SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;
                this.NotifyPropertyChanged("SelectedUser");
            }
        }
    }
}
