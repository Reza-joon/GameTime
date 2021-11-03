using GameTime.ViewModels;
using System;
using System.Windows.Input;

namespace GameTime.Commands
{
     public class ClearNewJeuxImageCommand : ICommand, IDisposable
    {
        public event EventHandler CanExecuteChanged;

         public ClearNewJeuxImageCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

          public bool CanExecute(object parameter)
        {
            if (App.Controller.NewJeuxImage == MainViewModel.defaultJeuxImage)
                return false;

            return true;
        }

          public void Execute(object parameter)
        {
            if (CanExecute(parameter) == false)
                return;

            App.Controller.NewJeuxImage = MainViewModel.defaultJeuxImage;
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "NewJeuxImage")
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
