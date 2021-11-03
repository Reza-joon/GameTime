using MusicViewer.Commands;
using MusicViewer.ViewModels;
using MusicViewer.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MusicViewer.ViewModels
{
    /// <summary>
    /// AddGame ViewModel.
    /// </summary>
    /// <seealso cref="MusicViewer.ViewModels.BaseINotify" />
    public class AddGameViewModel : BaseINotify, IDisposable
    {
        #region Commands
        /// <summary>
        /// Gets or sets the add new game command.
        /// </summary>
        /// <value>
        /// The add new game command.
        /// </value>
        public AddNewGameCommand AddNewGameCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the browse new game cover path command.
        /// </summary>
        /// <value>
        /// The browse new game cover path command.
        /// </value>
        public BrowseNewJeuxImageCommand BrowseNewJeuxImageCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the clear new game cover command.
        /// </summary>
        /// <value>
        /// The clear new game cover command.
        /// </value>
        public ClearNewJeuxImageCommand ClearNewGameCoverCommand
        {
            get;
            private set;
        }
        #endregion

        /// <summary>
        /// Gets the new games collection.
        /// </summary>
        /// <value>
        /// The new games collection.
        /// </value>
        public ReadOnlyObservableCollection<Game> NewGamesCollection
        {
            get
            {
                return App.Controller.GamesCollection;
            }
        }

        #region NewGame Properties
        /// <summary>
        /// Gets or sets the new name of the game.
        /// Rest of the properties work identically.
        /// </summary>
        /// <value>
        /// The new name of the game.
        /// </value>
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
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGameViewModel"/> class.
        /// Sets the game cover to the default.
        /// </summary>
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
        /// <summary>
        /// On controller property changed, call NotifyPropertyChanged for PropertyName.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        void onControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.NotifyPropertyChanged(e.PropertyName);
        }

        /// <summary>
        /// On GameAdded for AddNewGameCommand, clears the NewJeuxDescription and NewGamesName textboxes, and sets NewJeuxImage to 
        /// default value.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
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
