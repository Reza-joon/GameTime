using MusicViewer.Managers;
using MusicViewer.ViewModels;
using MusicViewer.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace MusicViewer.Commands
{

    public class OpenViewUserCommand : ICommand
    {

        public OpenViewUserCommand()
        {
        }

 public bool CanExecute(object parameter)
        {
            return true;
        }

      public void Execute(object parameter)
        {
            Window newViewUserView = new UpdateorDeleteUserView();
            WindowManager.ViewUserWindow = newViewUserView;


            UpdateOrDeleteUserViewModel newUpdateOrDeleteUserViewModel = new UpdateOrDeleteUserViewModel();
            newViewUserView.DataContext = newUpdateOrDeleteUserViewModel;

            newViewUserView.ShowDialog();

            newViewUserView.DataContext = null;
            newUpdateOrDeleteUserViewModel.Dispose();
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
