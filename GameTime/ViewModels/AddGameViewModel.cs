using Gametime.Commands;
using Gametime.ViewModels;
using Gametime.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Gametime.ViewModels
{
     public class AddGameViewModel : BaseINotify, IDisposable
    {
        #region Commands
 
        public AddNewGameCommand AddNewGameCommand
        {
            get;
            private set;
        }

        public BrowseNewJeuxImageCommand BrowseNewJeuxImageCommand
        {
            get;
            private set;
        }


        public ClearNewJeuxImageCommand ClearNewGameCoverCommand
        {
            get;
            private set;
        }
        #endregion


        public ReadOnlyObservableCollection<Game> NewGamesCollection
        {
            get
            {
                return App.Controller.GamesCollection;
            }
        }

        #region NewGame Properties

        public string NewJeuxNom
        {
            get
            {
                return App.Controller.NewJeuxNom;
            }

            set
            {
                App.Controller.NewJeuxNom = value;
            }
        }

        public string NewJeuxDescription
        {
            get
            {
                return App.Controller.NewJeuxDescription;
            }
            set
            {
                App.Controller.NewJeuxDescription = value;
            }
        }

        public string NewJeuxImage
        {
            get
            {
                return App.Controller.NewJeuxImage;
            }
            set
            {
                App.Controller.NewJeuxImage = value;
            }
        }

        public string NewJeuxDate
        {
            get
            {
                return App.Controller.NewJeuxDate;
            }
            set
            {
                App.Controller.NewJeuxDate = value;
            }
        }

        public string NewJeuxGenre
        {
            get
            {
                return App.Controller.NewJeuxGenre;
            }
            set
            {
                App.Controller.NewJeuxGenre = value;
            }
        }

        public string NewJeuxPEGI
        {
            get
            {
                return App.Controller.NewJeuxPEGI;
            }
            set
            {
                App.Controller.NewJeuxPEGI = value;
            }
        }

        public string NewJeuxPlatforme
        {
            get
            {
                return App.Controller.NewJeuxPlatforme;
            }
            set
            {
                App.Controller.NewJeuxPlatforme = value;
            }
        }

        public string NewJeuxVersion
        {
            get
            {
                return App.Controller.NewJeuxVersion;
            }
            set
            {
                App.Controller.NewJeuxVersion = value;
            }
        }
        #endregion

        #region AddGameViewModel Constructor
 
        public AddGameViewModel()
        {
            this.NewJeuxImage = MainViewModel.defaultJeuxImage;

            this.AddNewGameCommand = new AddNewGameCommand();
            this.BrowseNewJeuxImageCommand = new BrowseNewJeuxImageCommand();
            this.ClearNewGameCoverCommand = new ClearNewJeuxImageCommand();

            App.Controller.PropertyChanged += onControllerPropertyChanged;
            AddNewGameCommand.GameAdded += onAddNewGameCommandGameAdded;
        }
        #endregion

        #region PropertyChanged Methods
         void onControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.NotifyPropertyChanged(e.PropertyName);
        }

         void onAddNewGameCommandGameAdded(object sender, EventArgs e)
        {
            NewJeuxDescription = string.Empty;
            NewJeuxNom = string.Empty;
            NewJeuxImage = MainViewModel.defaultJeuxImage;
            NewJeuxDate = string.Empty;
            NewJeuxGenre = string.Empty;
            NewJeuxPEGI = string.Empty;
            NewJeuxPlatforme = string.Empty;
            NewJeuxVersion = string.Empty;
        }
        #endregion

          public void Dispose()
        {
            if (AddNewGameCommand != null)
            {
                AddNewGameCommand.Dispose();
                AddNewGameCommand = null;
            }

            if (ClearNewGameCoverCommand != null)
            {
                ClearNewGameCoverCommand.Dispose();
                ClearNewGameCoverCommand = null;
            }
        }
    }
}
