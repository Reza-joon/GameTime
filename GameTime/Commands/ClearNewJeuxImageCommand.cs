using MusicViewer.ViewModels;
using System;
using System.Windows.Input;

namespace MusicViewer.Commands
{
    /// <summary>
    /// Clears the game cover path for new game.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class ClearNewJeuxImageCommand : ICommand, IDisposable
    {
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearNewJeuxImageCommand"/> class.
        /// </summary>
        public ClearNewJeuxImageCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            if (App.Controller.NewJeuxImage == MainViewModel.defaultJeuxImage)
                return false;

            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// Sets the new game's game cover path to the default.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
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
