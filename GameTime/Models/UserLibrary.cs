using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace GameTime.Models
{

    public class UserLibrary
    {
        private string userLibraryFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UserLibrary_GameTime.xml");

        // UserLibrary Constructor
        public UserLibrary()
        {

        }

        // ObservableCollection of Users
        private ObservableCollection<User> usersCollection = new ObservableCollection<User>();

        public ObservableCollection<User> UsersCollection
        {
            get
            {
                return usersCollection;
            }
        }

        public void LoadUsers()
        {
            UsersCollection.Add(new User("admin", "T", "Reza", "11.11.1988", "xxx@gmail.com", "admin"));
            UsersCollection.Add(new User("User2", "H", "Karim", "2009, 1, 16", "yyy@gmail.com", "admin"));
            UsersCollection.Add(new User("User3", "X", "C", "11.11.2020", "zzz@gmail.com", "admin"));

        }

        public void Load()
        {
            //if (File.Exists(userLibraryFileName))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<User>));

            //    using (StreamReader reader = new StreamReader(userLibraryFileName))
            //    {
            //        this.usersCollection = (ObservableCollection<User>)xs.Deserialize(reader);
            //    }
            //}

            //else
            //{
            LoadUsers();
            //}
        }

        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<User>));

            using (StreamWriter writer = new StreamWriter(userLibraryFileName))
            {
                xs.Serialize(writer, this.usersCollection);
            }
        }

    }
}
