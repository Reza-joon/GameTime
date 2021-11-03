using GameTime.Models;
using System;
using System.Windows.Input;

namespace GameTime.Commands
{

    public class UpdateJeuxDescriptionCommand : ICommand, IDisposable
    {

        public event EventHandler GameAdded;
        public event EventHandler CanExecuteChanged;

        public UpdateJeuxDescriptionCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

 
        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.UpdatedJeuxDescription))
                return false;

            return true;
        }

         public void Execute(object parameter)
        {
            
            Game newGame = new Game(App.Controller.SelectedItem.JeuxNom, App.Controller.UpdatedJeuxDescription, App.Controller.SelectedItem.JeuxImage, App.Controller.SelectedItem.JeuxDate, App.Controller.SelectedItem.JeuxGenre, App.Controller.SelectedItem.JeuxPEGI, App.Controller.SelectedItem.JeuxPlatforme, App.Controller.SelectedItem.JeuxVersion);
            Game oldSelectedItem = App.Controller.SelectedItem;

            App.Controller.AddGame(newGame);
            App.Controller.SelectedItem = newGame;
            App.Controller.RemoveGame(oldSelectedItem);

            if (GameAdded != null)
            {
                GameAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UpdatedJeuxDescription")
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
