using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace GameTime.Models
{

    public class GameLibrary
    {
        private string userLibraryFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UserLibrary_MusicViewer.xml");

        #region GameLibrary Constructor

        public GameLibrary()
        {

        }
        #endregion

        #region ObservableCollection of Games
        private ObservableCollection<Game> gamesCollection = new ObservableCollection<Game>();

        public ObservableCollection<Game> GamesCollection
        {
            get
            {
                return gamesCollection;
            }
        }

        public void LoadGames()
        {
            GamesCollection.Add(new Game("If You're Reading This It's Too Late", "Drake", "/MusicViewer;component/Images/ifyourereadingthisitstoolate.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Defense of the Genre", "Say Anything", "/MusicViewer;component/Images/indefenseofthegenre.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("Picaresque", "The Decemberists", "/MusicViewer;component/Images/picaresque.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Evening Air", "Future Islands", "/MusicViewer;component/Images/ineveningair.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("You're Gonna Miss It All", "Modern Baseball", "/MusicViewer;component/Images/youregonnamissitall.jpg", "test", "test", "test", "test", "test"));
        }


        public void Load()
        {
            //if (File.Exists(userLibraryFileName))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

            //    using (StreamReader reader = new StreamReader(userLibraryFileName))
            //    {
            //        this.gamesCollection = (ObservableCollection<Game>)xs.Deserialize(reader);
            //    }
            //}

            //else
            //{
            LoadGames();
            //}
        }


        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

            using (StreamWriter writer = new StreamWriter(userLibraryFileName))
            {
                xs.Serialize(writer, this.gamesCollection);
            }
        }
        #endregion
    }
}
