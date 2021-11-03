using GameTime.Commands;
using GameTime.ViewModels;
using GameTime.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace GameTime.ViewModels
{

    public class UpdateOrDeleteViewModel : BaseINotify, IDisposable
    {
        #region Commands
     
        public ICommand RemoveGameCommand
        {
            get;
            private set;
        }


        public UpdateJeuxNomCommand UpdateJeuxNomCommand
        {
            get;
            private set;
        }

    
        public UpdateJeuxDescriptionCommand UpdateJeuxDescriptionCommand
        {
            get;
            private set;
        }

  
        public BrowseUpdateJeuxImageCommand BrowseUpdateJeuxImageCommand
        {
            get;
            private set;
        }

        public UpdateJeuxDateCommand UpdateJeuxDateCommand
        {
            get;
            private set;
        }

        public UpdateJeuxGenreCommand UpdateJeuxGenreCommand
        {
            get;
            private set;
        }

        public UpdateJeuxPEGICommand UpdateJeuxPEGICommand
        {
            get;
            private set;
        }

        public UpdateJeuxPlatformeCommand UpdateJeuxPlatformeCommand
        {
            get;
            private set;
        }

          public UpdateJeuxVersionCommand UpdateJeuxVersionCommand
        {
            get;
            private set;
        }

        

    
        public ClearUpdateJeuxImageCommand ClearUpdateJeuxImageCommand
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
                //this.NotifyPropertyChanged("NewJeuxNom");
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
                //this.NotifyPropertyChanged("NewJeuxDescription");
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
                if (value == null || value == "")
                    App.Controller.NewJeuxImage = MainViewModel.defaultJeuxImage;
                //this.NotifyPropertyChanged("NewJeuxImage");
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
                //this.NotifyPropertyChanged("NewJeuxDate");
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
                //this.NotifyPropertyChanged("NewJeuxGenre");
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
                //this.NotifyPropertyChanged("NewJeuxPEGI");
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
                //this.NotifyPropertyChanged("NewJeuxPlatforme");
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
                //this.NotifyPropertyChanged("NewJeuxVersion");
            }
        }




        public Game SelectedItem
        {
            get
            {
                return App.Controller.SelectedItem;
            }
            set
            {
                App.Controller.SelectedItem = value;
                //this.NotifyPropertyChanged("SelectedItem");
            }
        }

        public string UpdatedJeuxNom
        {
            get
            {
                return App.Controller.UpdatedJeuxNom;
            }
            set
            {
                App.Controller.UpdatedJeuxNom = value;
                //this.NotifyPropertyChanged("UpdatedJeuxNom");
            }
        }

        public string UpdatedJeuxDescription
        {
            get
            {
                return App.Controller.UpdatedJeuxDescription;
            }
            set
            {
                App.Controller.UpdatedJeuxDescription = value;
                //this.NotifyPropertyChanged("UpdatedJeuxDescription");
            }
        }

        public string UpdatedJeuxDate
        {
            get
            {
                return App.Controller.UpdatedJeuxDate;
            }
            set
            {
                App.Controller.UpdatedJeuxDate = value;
                //this.NotifyPropertyChanged("UpdatedJeuxDate");
            }
        }

        public string UpdatedJeuxGenre
        {
            get
            {
                return App.Controller.UpdatedJeuxGenre;
            }
            set
            {
                App.Controller.UpdatedJeuxGenre = value;
                //this.NotifyPropertyChanged("UpdatedJeuxGenre");
            }
        }

        public string UpdatedJeuxPEGI
        {
            get
            {
                return App.Controller.UpdatedJeuxPEGI;
            }
            set
            {
                App.Controller.UpdatedJeuxPEGI = value;
                //this.NotifyPropertyChanged("UpdatedJeuxPEGI");
            }
        }

        public string UpdatedJeuxPlatforme
        {
            get
            {
                return App.Controller.UpdatedJeuxPlatforme;
            }
            set
            {
                App.Controller.UpdatedJeuxPlatforme = value;
                //this.NotifyPropertyChanged("UpdatedJeuxPlatforme");
            }
        }

        public string UpdatedJeuxVersion
        {
            get
            {
                return App.Controller.UpdatedJeuxVersion;
            }
            set
            {
                App.Controller.UpdatedJeuxVersion = value;
                //this.NotifyPropertyChanged("UpdatedJeuxVersion");
            }
        }
        #endregion

        #region UpdateOrDeleteViewModel Constructor

        public UpdateOrDeleteViewModel()
        {
            this.RemoveGameCommand = new RemoveGameCommand();
            this.UpdateJeuxNomCommand = new UpdateJeuxNomCommand();
            this.UpdateJeuxDescriptionCommand = new UpdateJeuxDescriptionCommand();
            this.BrowseUpdateJeuxImageCommand = new BrowseUpdateJeuxImageCommand();
            this.ClearUpdateJeuxImageCommand = new ClearUpdateJeuxImageCommand();
            this.UpdateJeuxDateCommand = new UpdateJeuxDateCommand();
            this.UpdateJeuxGenreCommand = new UpdateJeuxGenreCommand();
            this.UpdateJeuxPEGICommand = new UpdateJeuxPEGICommand();
            this.UpdateJeuxPlatformeCommand = new UpdateJeuxPlatformeCommand();
            this.UpdateJeuxVersionCommand = new UpdateJeuxVersionCommand();

            App.Controller.PropertyChanged += onControllerPropertyChanged;
            UpdateJeuxNomCommand.GameAdded += onUpdateJeuxNomCommandGameAdded;
            UpdateJeuxDescriptionCommand.GameAdded += onUpdateJeuxDescriptionCommandGameAdded;
            UpdateJeuxDateCommand.GameAdded += onUpdateJeuxDateCommandGameAdded;
            UpdateJeuxGenreCommand.GameAdded += onUpdateJeuxGenreCommandGameAdded;
            UpdateJeuxPEGICommand.GameAdded += onUpdateJeuxPEGICommandGameAdded;
            UpdateJeuxPlatformeCommand.GameAdded += onUpdateJeuxPlatformeCommandGameAdded;
            UpdateJeuxVersionCommand.GameAdded += onUpdateJeuxVersionCommandGameAdded;
        }
        #endregion

        #region PropertyChanged Methods
         void onControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.NotifyPropertyChanged(e.PropertyName);
        }

         void onUpdateJeuxDescriptionCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxDescription = string.Empty;
        }

        void onUpdateJeuxDateCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxDate = string.Empty;
        }

        void onUpdateJeuxGenreCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxGenre = string.Empty;
        }

        void onUpdateJeuxPEGICommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxPEGI = string.Empty;
        }

        void onUpdateJeuxPlatformeCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxPlatforme = string.Empty;
        }

        void onUpdateJeuxVersionCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxVersion = string.Empty;
        }


         void onUpdateJeuxNomCommandGameAdded(object sender, EventArgs e)
        {
            UpdatedJeuxNom = string.Empty;
        }
        #endregion

        public void Dispose()
        {
            if (UpdateJeuxNomCommand != null)
            {
                UpdateJeuxNomCommand.Dispose();
                UpdateJeuxNomCommand = null;
            }

            if (UpdateJeuxDescriptionCommand != null)
            {
                UpdateJeuxDescriptionCommand.Dispose();
                UpdateJeuxDescriptionCommand = null;
            }

            if (ClearUpdateJeuxImageCommand != null)
            {
                ClearUpdateJeuxImageCommand.Dispose();
                ClearUpdateJeuxImageCommand = null;
            }

            if (UpdateJeuxDateCommand != null)
            {
                UpdateJeuxDateCommand.Dispose();
                UpdateJeuxDateCommand = null;
            }

            if (UpdateJeuxGenreCommand != null)
            {
                UpdateJeuxGenreCommand.Dispose();
                UpdateJeuxGenreCommand = null;
            }

            if (UpdateJeuxPEGICommand != null)
            {
                UpdateJeuxPEGICommand.Dispose();
                UpdateJeuxPEGICommand = null;
            }

            if (UpdateJeuxPlatformeCommand != null)
            {
                UpdateJeuxPlatformeCommand.Dispose();
                UpdateJeuxPlatformeCommand = null;
            }

            if (UpdateJeuxVersionCommand != null)
            {
                UpdateJeuxVersionCommand.Dispose();
                UpdateJeuxVersionCommand = null;
            }
        }
    }

}
