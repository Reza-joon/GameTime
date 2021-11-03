using GameTime.Models;
using System;
using System.Windows.Input;

namespace GameTime.Commands
{

    public class AddNewGameCommand : ICommand
    {
        public event EventHandler GameAdded;
        public event EventHandler CanExecuteChanged;

        public AddNewGameCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }


        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.NewJeuxNom) || String.IsNullOrEmpty(App.Controller.NewJeuxDescription))
                return false;

            return true;
        }

         public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            Game newGame = new Game(App.Controller.NewJeuxNom, App.Controller.NewJeuxDescription, App.Controller.NewJeuxImage, App.Controller.NewJeuxDate, App.Controller.NewJeuxGenre, App.Controller.NewJeuxPEGI, App.Controller.NewJeuxPlatforme, App.Controller.NewJeuxVersion);

            App.Controller.AddGame(newGame);

            if (GameAdded != null)
            {
                GameAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "NewJeuxDescription" || e.PropertyName == "NewJeuxNom")
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
