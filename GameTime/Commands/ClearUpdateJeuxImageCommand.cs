using GameTime.ViewModels;
using GameTime.Models;
using System;
using System.Windows.Input;

namespace GameTime.Commands
{
     public class ClearUpdateJeuxImageCommand : ICommand, IDisposable
    {
        public event EventHandler CanExecuteChanged;

        public ClearUpdateJeuxImageCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

           public bool CanExecute(object parameter)
        {
            if (App.Controller.SelectedItem.JeuxImage == MainViewModel.defaultJeuxImage)
                return false;

            return true;
        }

       public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            App.Controller.SelectedItem.JeuxImage = MainViewModel.defaultJeuxImage;

            Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.SelectedItem.JeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.SelectedItem.JeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);

            Game oldSelectedItem = App.Controller.SelectedItem;

            App.Controller.AddGame(newGame);
            App.Controller.SelectedItem = newGame;
            App.Controller.RemoveGame(oldSelectedItem);
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedItem")
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
