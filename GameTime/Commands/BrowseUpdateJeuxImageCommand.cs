using Microsoft.Win32;
using GameTime.Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameTime.Commands
{
    public class BrowseUpdateJeuxImageCommand : ICommand
    {
         public BrowseUpdateJeuxImageCommand()
        {

        }

         public bool CanExecute(object parameter)
        {
            return true;
        }

         public void Execute(object parameter)
        {
            if (App.Controller.SelectedItem == null)
            {
                MessageBox.Show("Please select an game to update", "Simple Music Viewer v1.0", MessageBoxButton.OK);
            }

            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (openFileDialog.ShowDialog() == true)
                {
                    App.Controller.SelectedItem.JeuxImage = openFileDialog.FileName;
                }

                if (GameAdded != null)
                {
                    GameAdded(this, EventArgs.Empty);
                }

                Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.SelectedItem.JeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.SelectedItem.JeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);
                Game oldSelectedItem = App.Controller.SelectedItem;

                App.Controller.AddGame(newGame);
                App.Controller.SelectedItem = newGame;
                App.Controller.RemoveGame(oldSelectedItem);
            }
        }

        public event EventHandler GameAdded;

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
